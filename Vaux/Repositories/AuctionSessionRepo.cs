using AutoMapper;
using System.Linq.Expressions;
using Twilio.TwiML.Voice;
using Vaux.DbContext;
using Vaux.Models;
using Vaux.Models.Enums;
using Vaux.Repositories.Interface;

namespace Vaux.Repositories
{
    public class AuctionSessionRepo : BaseRepo<AuctionSession>, IAuctionSessionRepo
    {
        private readonly INotificationRepo _notificationRepo;
        private readonly IConfiguration _configuration;
        public AuctionSessionRepo(VxDbc vxDbc, IMapper mapper, INotificationRepo notificationRepo, IConfiguration configuration) : base(vxDbc, mapper)
        {
            _notificationRepo = notificationRepo;
            _configuration = configuration;
        }

        public TOut Create<TOut, TIn>(TIn data, ICollection<int> itemIds)
        {
            var auc = Create(data);

            auc.Items = _vxDbc.Items.Where(e => itemIds.Contains(e.Id) && e.Status == ItemStatus.AUCTION_PENDING && e.AuctionSessions!.All(auc => auc.Status == AuctionSessionStatus.FINISHED)).ToList();

            Save();
            return Map<TOut>(auc);
        }

        public TOut Update<TOut, TIn>(Expression<Func<AuctionSession, bool>> predicate, TIn data, ICollection<int> itemIds)
        {
            var auc = Update(predicate, data);

            auc.Items?.Clear();

            auc.Items = _vxDbc.Items.Where(e => itemIds.Contains(e.Id) && e.Status == ItemStatus.AUCTION_PENDING && e.AuctionSessions!.All(a => a.Status == AuctionSessionStatus.FINISHED || a.Id == auc.Id)).ToList();

            Save();

            return Map<TOut>(auc);
        }

        protected override AuctionSession Create<TIn>(TIn data)
        {
            var auc = base.Create(data);
            auc.StartDate = auc.StartDate.Date.AddHours(7);
            auc.EndDate = auc.EndDate.Date.AddHours(19);

            return auc;
        }

        protected override AuctionSession Update<TIn>(Expression<Func<AuctionSession, bool>> predicate, TIn data)
        {
            var auc = base.Update(predicate, data);
            auc.StartDate = auc.StartDate.Date.AddHours(7);
            auc.EndDate = auc.EndDate.Date.AddHours(19);

            return auc;
        }

        public void StartSession()
        {
            var eligibleAuctions = _vxDbc.AuctionSessions.Where(e => e.StartDate.Date == DateTime.Today).ToList();
            foreach (var auc in eligibleAuctions)
            {
                auc.Status = AuctionSessionStatus.ONGOING;

                foreach (var item in auc.Items!)
                {
                    item.Status = ItemStatus.AUCTION_IN_PROGRESS;
                    item.OngoingSession = auc;
                    item.StatusChanges!.Add(new StatusChange()
                    {
                        StatusFrom = ItemStatus.AUCTION_PENDING.ToString(),
                        StatusTo = ItemStatus.AUCTION_IN_PROGRESS.ToString(),
                        StatusChangedById = 1,
                        StatusChangeReason = "Start auction"
                    });

                    _notificationRepo.Create<Notification>(e => e.Id == item.SellerId, $"Sản phẩm {item.Name} đã bắt đầu được đấu giá", $"{_configuration["JWT:Audience"]}/seller/detail?itemId={item.Id}");
                }
            }

            _vxDbc.SaveChanges();
        }

        public void ForceStartSession(int id)
        {
            var auc = _dbSet.FirstOrDefault(e => e.Id == id && e.Status == AuctionSessionStatus.PENDING);

            auc.Status = AuctionSessionStatus.ONGOING;
            auc.StartDate = DateTime.Today.AddHours(7);

            if (auc.EndDate.Date < DateTime.Today)
            {
                auc.EndDate = DateTime.Today.AddHours(19);
            }

            foreach (var item in auc.Items!)
            {
                item.Status = ItemStatus.AUCTION_IN_PROGRESS;
                item.OngoingSession = auc;
                item.StatusChanges!.Add(new StatusChange()
                {
                    StatusFrom = ItemStatus.AUCTION_PENDING.ToString(),
                    StatusTo = ItemStatus.AUCTION_IN_PROGRESS.ToString(),
                    StatusChangedById = 1,
                    StatusChangeReason = "Start auction"
                });

                _notificationRepo.Create<Notification>(e => e.Id == item.SellerId, $"Sản phẩm {item.Name} đã bắt đầu được đấu giá", $"{_configuration["JWT:Audience"]}/seller/detail?itemId={item.Id}");
            }

            _vxDbc.SaveChanges();
        }

        public void EndSession()
        {
            var eligibleAuctions = _vxDbc.AuctionSessions.Where(e => e.EndDate.Date == DateTime.Today).ToList();
            foreach (var auc in eligibleAuctions)
            {
                AuctionSessionReport report = new AuctionSessionReport()
                {
                    AuctionedItems = 0,
                    SoldItems = 0,
                    UnauctionedItems = 0,
                    UnpaidItems = 0,
                    ActiveItems = 0,
                    ActiveBids = 0,
                    ActiveBidders = 0,
                    ActiveSellers = 0,
                    TotalRevenue = 0,
                };
                auc.Report = report;
                auc.Status = AuctionSessionStatus.FINISHED;

                report.ActiveBidders = _vxDbc.Bids.Where(e => e.AuctionSessionId == auc.Id).GroupBy(e => e.UserId).Count();
                report.ActiveSellers = auc.Items!.GroupBy(e => e.SellerId).Count();

                foreach (var item in auc.Items!)
                {
                    report.ActiveItems++;
                    report.ActiveBids += item.Bids!.Count;
                    var highestBid = item.HighestBid;
                    if (highestBid?.Amount >= item.ReservePrice)
                    {
                        report.AuctionedItems++;
                        item.Status = ItemStatus.PAYMENT_PENDING;
                        item.OngoingSession = null;
                        item.StatusChanges!.Add(new StatusChange()
                        {
                            StatusFrom = ItemStatus.AUCTION_IN_PROGRESS.ToString(),
                            StatusTo = ItemStatus.PAYMENT_PENDING.ToString(),
                            StatusChangedById = 1,
                            StatusChangeReason = $"Item won by user {highestBid.UserId}"
                        });

                        item.WonDate = DateTime.Today;
                        item.PaymentDueDate = DateTime.Today.AddDays(7);

                        _notificationRepo.Create<Notification>(e => e.Id == item.SellerId, $"Sản phẩm {item.Name} đã được đấu giá thành công", $"{_configuration["JWT:Audience"]}/seller/detail?itemId={item.Id}");

                        _notificationRepo.Create<Notification>(e => e.Id == highestBid.UserId, $"Bạn đã thắng được sản phẩm {item.Name}", $"{_configuration["JWT:Audience"]}/account/items");
                    }
                    else
                    {
                        report.UnauctionedItems++;
                        item.Status = ItemStatus.RE_AUCTION_PENDING;
                        item.StatusChanges!.Add(new StatusChange()
                        {
                            StatusFrom = ItemStatus.AUCTION_IN_PROGRESS.ToString(),
                            StatusTo = ItemStatus.RE_AUCTION_PENDING.ToString(),
                            StatusChangedById = 1,
                            StatusChangeReason = $"Item auction failed"
                        });

                        item.HighestBid = null;

                        _notificationRepo.Create<Notification>(e => e.Id == item.SellerId, $"Sản phẩm {item.Name} đã không được đấu giá thành công", $"{_configuration["JWT:Audience"]}/seller/detail?itemId={item.Id}");
                    }
                }
            }

            _vxDbc.SaveChanges();
        }

        public void ForceEndSession(int id)
        {
            var auc = _dbSet.FirstOrDefault(e => e.Id == id && e.Status == AuctionSessionStatus.ONGOING);

            AuctionSessionReport report = new AuctionSessionReport()
            {
                AuctionedItems = 0,
                SoldItems = 0,
                UnauctionedItems = 0,
                UnpaidItems = 0,
                ActiveItems = 0,
                ActiveBids = 0,
                ActiveBidders = 0,
                ActiveSellers = 0,
                TotalRevenue = 0,
            };
            auc.Report = report;
            auc.Status = AuctionSessionStatus.FINISHED;
            auc.EndDate = DateTime.Today.AddHours(19);

            report.ActiveBidders = _vxDbc.Bids.Where(e => e.AuctionSessionId == auc.Id).GroupBy(e => e.UserId).Count();
            report.ActiveSellers = auc.Items!.GroupBy(e => e.SellerId).Count();

            foreach (var item in auc.Items!)
            {
                report.ActiveItems++;
                report.ActiveBids += item.Bids!.Count;
                var highestBid = item.HighestBid;
                if (highestBid?.Amount >= item.ReservePrice)
                {
                    report.AuctionedItems++;
                    item.Status = ItemStatus.PAYMENT_PENDING;
                    item.OngoingSession = null;
                    item.StatusChanges!.Add(new StatusChange()
                    {
                        StatusFrom = ItemStatus.AUCTION_IN_PROGRESS.ToString(),
                        StatusTo = ItemStatus.PAYMENT_PENDING.ToString(),
                        StatusChangedById = 1,
                        StatusChangeReason = $"Item won by user {highestBid.UserId}"
                    });

                    item.WonDate = DateTime.Today;
                    item.PaymentDueDate = DateTime.Today.AddDays(7);

                    _notificationRepo.Create<Notification>(e => e.Id == item.SellerId, $"Sản phẩm {item.Name} đã được đấu giá thành công", $"{_configuration["JWT:Audience"]}/seller/detail?itemId={item.Id}");

                    _notificationRepo.Create<Notification>(e => e.Id == highestBid.UserId, $"Bạn đã thắng được sản phẩm {item.Name}", $"{_configuration["JWT:Audience"]}/account/items");
                }
                else
                {
                    report.UnauctionedItems++;
                    item.Status = ItemStatus.RE_AUCTION_PENDING;
                    item.StatusChanges!.Add(new StatusChange()
                    {
                        StatusFrom = ItemStatus.AUCTION_IN_PROGRESS.ToString(),
                        StatusTo = ItemStatus.RE_AUCTION_PENDING.ToString(),
                        StatusChangedById = 1,
                        StatusChangeReason = $"Item auction failed"
                    });

                    item.HighestBid = null;

                    _notificationRepo.Create<Notification>(e => e.Id == item.SellerId, $"Sản phẩm {item.Name} đã không được đấu giá thành công", $"{_configuration["JWT:Audience"]}/seller/detail?itemId={item.Id}");
                }
            }

            _vxDbc.SaveChanges();
        }
    }
}

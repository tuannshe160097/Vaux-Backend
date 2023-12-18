using AutoMapper;
using System.Linq;
using System.Linq.Expressions;
using Twilio.TwiML.Voice;
using Vaux.DbContext;
using Vaux.DTO;
using Vaux.Models;
using Vaux.Models.Enums;
using Vaux.Repositories.Interface;

namespace Vaux.Repositories
{
    public class OrderRepo : BaseRepo<Order>, IOrderRepo
    {
        private readonly EmailRepo _emailRepo;

        public OrderRepo(VxDbc vxDbc, IMapper mapper, IHttpContextAccessor httpContextAccessor, EmailRepo emailRepo) : base(vxDbc, mapper, httpContextAccessor)
        {
            _emailRepo = emailRepo;
        }

        public TOut Create<TOut>(int[] itemIds)
        {
            var user = _vxDbc.Users.FirstOrDefault(e => e.Id.ToString() == _user.Identity.Name);

            Order order = new()
            {
                UserId = user.Id,
                Address = user.Address,
                ReceiverName = user.Name,
                ReceiverPhone = user.Phone,
                TotalCost = 0
            };

            List<Item> items = _vxDbc.Items.Where(e => e.HighestBid!.UserId.ToString() == _user.Identity.Name && itemIds.Contains(e.Id)).ToList();

            List<Shipment> shipments = new();
            foreach (var item in items)
            {
                var shipment = shipments.FirstOrDefault(e => e.SellerId == item.SellerId);
                if (shipment == null)
                {
                    shipment = new();
                    shipment.ItemCost = 0;
                    shipment.ShippingCost = 40000;
                    shipment.SellerId = item.SellerId;
                    shipment.Address = item.Seller.Address;

                    shipments.Add(shipment);
                    shipment.Items = new List<Item>();
                }

                shipment.Items.Add(item);
                shipment.ShippingCost += 5000;
                shipment.ItemCost += item.HighestBid!.Amount + CalculateBuyerProtectionFee(item.HighestBid.Amount);
                order.TotalCost += shipment.ItemCost + shipment.ShippingCost;
            }

            order.Items = items;
            order.Shipment = shipments;

            _dbSet.Add(order);
            Save();

            return Map<TOut>(order);
        }

        public TOut ConfirmPaid<TOut>(Expression<Func<Order, bool>> predicate)
        {
            var res = _queryGlobal.FirstOrDefault(predicate);

            res.Status = OrderStatus.PAID;
            foreach (var shipment in res.Shipment)
            {
                foreach (var item in shipment.Items)
                {
                    item.Status = ItemStatus.PAID;

                    item.StatusChanges!.Add(new StatusChange
                    {
                        StatusFrom = nameof(ItemStatus.PAYMENT_PENDING),
                        StatusTo = nameof(ItemStatus.PAID),

                        StatusChangedById = int.Parse(_user.Identity.Name),
                        StatusChangeReason = $"Changed status from {nameof(ItemStatus.PAYMENT_PENDING)} to {nameof(ItemStatus.PAID)}"
                    });

                    item.ItemPayment = new()
                    {
                        SellerPayout = CalculateSellerPayment(item.HighestBid!.Amount),
                        ExpertPayout = CalculateExpertPayment(item.HighestBid!.Amount),
                        Revenue = CalculateRevenue(item.HighestBid!.Amount),
                        BuyerProtectionFee = CalculateBuyerProtectionFee(item.HighestBid!.Amount),
                    };

                    var report = item.HighestBid.AuctionSession!.Report;
                    report!.TotalRevenue += item.ItemPayment.Revenue;
                    report.SoldItems++;
                }
            }

            foreach (var shipment in res.Shipment)
            {
                string content =
                    $"Mã đơn: {shipment.Id}\n" +
                    $"Người gửi: {shipment.Seller!.Name}\n" +
                    $"SĐT người gửi: {shipment.Seller.Phone}\n" +
                    $"Địa chỉ gửi: {shipment.Address}\n" +
                    $"Người nhận: {shipment.Order.User.Name}\n" +
                    $"SĐT người nhận: {shipment.Order.User.Phone}\n" +
                    $"Địa chỉ nhận: {shipment.Order.Address}\n\n" +
                    $"Món hàng: \n";
                foreach (var item in shipment.Items)
                {
                    content += $"- {item.Name}\n";
                }

                _emailRepo.SendEmail("tuannshe160097@fpt.edu.vn", $"Đơn ship {shipment.Id}", content);
            }

            Save();

            return Map<TOut>(res);
        }

        public static long CalculateBuyerProtectionFee(long bidAmount)
        {
            return (long)(bidAmount * 0.09);
        }

        private static long CalculateSellerPayment(long bidAmount)
        {
            return (long)(bidAmount * 0.87);
        }

        private static long CalculateExpertPayment(long bidAmount)
        {
            return 20000 + (long)(bidAmount * 0.05);
        }

        private static long CalculateRevenue(long bidAmount)
        {
            return bidAmount - CalculateSellerPayment(bidAmount) - CalculateExpertPayment(bidAmount);
        }
    }
}

﻿using AutoMapper;
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
        public OrderRepo(VxDbc vxDbc, IMapper mapper, IHttpContextAccessor httpContextAccessor) : base(vxDbc, mapper, httpContextAccessor)
        {
        }

        public TOut Create<TOut>(int[] itemIds)
        {
            var user = _vxDbc.Users.FirstOrDefault(e => e.Id.ToString() == _user.Identity.Name);

            Order order = new()
            {
                UserId = user.Id,
                City = user.City,
                Street = user.Street,
                District = user.District,
                HouseNumber = user.HouseNumber,
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
                    shipment.ShippingCost = 0;
                    shipment.SellerId = item.SellerId;
                    shipment.City = item.Seller.City;
                    shipment.Street = item.Seller.Street;
                    shipment.District = item.Seller.District;
                    shipment.HouseNumber = item.Seller.HouseNumber;

                    shipments.Add(shipment);
                }

                shipment.Items.Add(item);
                shipment.ShippingCost += 10;
                shipment.ItemCost += item.HighestBid!.Amount;
                order.TotalCost += shipment.ItemCost + shipment.ShippingCost;
            }

            order.Items = items;
            order.Shipment = shipments;
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

                    item.SellerPayment = new()
                    {
                        Amount = CalculateSellerPayment(item.HighestBid!.Amount)
                    };
                }
            }

            //@TODO: Send email

            Save();

            return Map<TOut>(res);
        }

        private static long CalculateSellerPayment(long bidAmount)
        {
            return bidAmount;
        }
    }
}
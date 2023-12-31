﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vaux.DTO.Out;
using Vaux.Models;
using Vaux.Models.Enums;
using Vaux.Repositories;
using Vaux.Repositories.Interface;
using Vaux.VNPayIntegration;

namespace Vaux.Controllers
{
    [Route("api/ItemPayment")]
    [ApiController]
    [Authorize(Roles = $"{nameof(RoleId.MODERATOR)},{nameof(RoleId.ADMIN)}")]
    public class ItemPaymentController : ControllerBase
    {
        private readonly IItemPaymentRepo _itemPaymentRepo;

        public ItemPaymentController(IItemPaymentRepo itemPaymentRepo)
        {
            _itemPaymentRepo = itemPaymentRepo;
        }

        [HttpGet]
        public IActionResult Get(int pageNum = 1, int pageSize = -1, bool? completed = null)
        {
            var query = _itemPaymentRepo.Query();
            query = query.OrderByDescending(e => e.Id);

            if (completed == true)
            {
                query = query.Where(e => e.ExpertPaymentStatus == PaymentStatus.PAID && e.SellerPaymentStatus == PaymentStatus.PAID);
            }

            if (completed == false)
            {
                query = query.Where(e => e.ExpertPaymentStatus == PaymentStatus.UNPAID || e.SellerPaymentStatus == PaymentStatus.UNPAID);
            }

            return Ok(_itemPaymentRepo.WrapListResult<ItemPaymentOutDTO>(query, (pageNum - 1) * pageSize, pageSize));
        }

        [HttpPatch]
        [Route("{id}/PaySeller")]
        public IActionResult PaySeller(int id)
        {
            var itemPayment = _itemPaymentRepo.Get<ItemPayment>(e => e.Id == id && e.SellerPaymentStatus == PaymentStatus.UNPAID);
            if (itemPayment == null)
            {
                return BadRequest("Người bán đã được thanh toán");
            }

            itemPayment.SellerPaymentStatus = PaymentStatus.PAID;
            itemPayment.SellerPaymentApprovedById = int.Parse(User.Identity.Name);

            return Ok(_itemPaymentRepo.Update<ItemPaymentOutDTO, ItemPayment>(e => e.Id == id, itemPayment));
        }

        [HttpPatch]
        [Route("{id}/PayExpert")]
        public IActionResult PayExpert(int id)
        {
            var itemPayment = _itemPaymentRepo.Get<ItemPayment>(e => e.Id == id && e.ExpertPaymentStatus == PaymentStatus.UNPAID);
            if (itemPayment == null)
            {
                return BadRequest("Kiểm định viên đã được thanh toán");
            }

            itemPayment.ExpertPaymentStatus = PaymentStatus.PAID;
            itemPayment.ExpertPaymentApprovedById = int.Parse(User.Identity.Name);

            return Ok(_itemPaymentRepo.Update<ItemPaymentOutDTO, ItemPayment>(e => e.Id == id, itemPayment));
        }
    }
}

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;
using Vaux.DTO;
using Vaux.Models.Enums;
using Vaux.Repositories.Interface;

namespace Vaux.Controllers
{
    [Route("api/Seller/ItemApplication")]
    [ApiController]
    [Authorize(Roles = nameof(RoleId.SELLER))]
    public class ItemApplicationController : ControllerBase
    {
        private IItemRepo _itemRepo;

        public ItemApplicationController(IItemRepo itemRepo)
        {
            _itemRepo = itemRepo;
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(int id)
        {
            var i = _itemRepo.Get(id);
            if (i == null || i.SellerId.ToString() != User.Identity.Name)
            {
                return BadRequest();
            }

            return Ok(i);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_itemRepo.GetByUser(int.Parse(User.Identity.Name)));
        }

        [HttpPost]
        public IActionResult Create(ItemApplicationDTO item)
        {
            var res = _itemRepo.Create(int.Parse(User.Identity.Name), item);
            return Ok(res);
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult Edit(int id, ItemApplicationDTO item)
        {
            var i = _itemRepo.Get(id);
            if (i == null || i.SellerId.ToString() != User.Identity.Name)
            {
                return BadRequest();
            }

            return Ok(_itemRepo.Update(id, item));
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(int id)
        {
            var i = _itemRepo.Get(id);
            if (i == null || i.SellerId.ToString() != User.Identity.Name)
            {
                return BadRequest();
            }

            return Ok(_itemRepo.Delete(id));
        }
    }
}

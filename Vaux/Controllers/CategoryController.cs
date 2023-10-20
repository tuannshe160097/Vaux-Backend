using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vaux.DTO;
using Vaux.Models.Enums;
using Vaux.Repositories.Interface;

namespace Vaux.Controllers
{
    [Route("api/Category")]
    [ApiController]
    [Authorize(Roles = $"{nameof(RoleId.MODERATOR)},{nameof(RoleId.ADMIN)}")]
    public class CategoryController : ControllerBase
    {
        private ICategoryRepo _categoryRepo;

        public CategoryController(ICategoryRepo categoryRepo)
        {
            _categoryRepo = categoryRepo;
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("")]
        public IActionResult GetAll(int pageNum = 1, int pageSize = 30, string? search = null)
        {
            return Ok(_categoryRepo.GetAll(pageNum, pageSize, search));
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_categoryRepo.Get(id));
        }

        [HttpPost]
        [Route("/api/Mod/Category")]
        public IActionResult Create([FromBody] CategoryDTO categoryDTO)
        {
            return Ok(_categoryRepo.Create(categoryDTO));
        }

        [HttpPut]
        [Route("/api/Mod/Category/{id}")]
        public IActionResult Update(int id, [FromBody] CategoryDTO categoryDTO)
        {
            var c = _categoryRepo.Get(id);
            if (c == null)
            {
                return BadRequest("Category doesn't exist");
            }

            return Ok(_categoryRepo.Update(id, categoryDTO));
        }
    }
}

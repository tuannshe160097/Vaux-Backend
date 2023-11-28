using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Vaux.DTO;
using Vaux.Models;
using Vaux.Models.Enums;
using Vaux.Repositories.Interface;

namespace Vaux.Controllers
{
    [Route("api/Mod/Category")]
    [ApiController]
    [Authorize(Roles = $"{nameof(RoleId.MODERATOR)},{nameof(RoleId.ADMIN)}")]
    public class CategoryController : ControllerBase
    {
        private readonly IBaseRepo<Category> _categoryRepo;

        public CategoryController(IBaseRepo<Category> categoryRepo)
        {
            _categoryRepo = categoryRepo;
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("/api/Category")]
        public IActionResult GetAll(int pageNum = 1, int pageSize = 30, string? search = null)
        {
            return Ok(_categoryRepo.GetAll<CategoryDTO>(e => search.IsNullOrEmpty() || e.Name.Contains(search!), e => e.Id, false, (pageNum-1) * pageSize, pageSize));
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("/api/Category/{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_categoryRepo.Get<CategoryDTO>(e => e.Id == id));
        }

        [HttpPost]
        public IActionResult Create([FromBody] CategoryDTO categoryDTO)
        {
            return Ok(_categoryRepo.Create<CategoryDTO, CategoryDTO>(categoryDTO));
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult Update(int id, [FromBody] CategoryDTO categoryDTO)
        {
            var c = _categoryRepo.Get<Category>(e => e.Id == id);
            if (c == null)
            {
                return BadRequest("Hạng mục không tồn tại!");
            }

            return Ok(_categoryRepo.Update<CategoryDTO, CategoryDTO>(e => e.Id == id, categoryDTO));
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(int id)
        {
            var c = _categoryRepo.Get<Category>(e => e.Id == id);
            if (c == null)
            {
                return BadRequest("Hạng mục không tồn tại!");
            }

            return Ok(_categoryRepo.Delete<CategoryDTO>(e => e.Id == id));
        }
    }
}

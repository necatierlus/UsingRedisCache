using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UsingRedisCache.Services;

namespace UsingRedisCache.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet("category/getall")]
        public IActionResult GetAll()
        {
            return Ok(_categoryService.GetAllCategory());
        }
    }
}

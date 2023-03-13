using Microsoft.AspNetCore.Mvc;
using PetStore.Services.Data;

using System.Threading.Tasks;

namespace PetStore.Web.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return this.View(await this.categoryService.GetAllCategoriesAsync());
        }
    }
}

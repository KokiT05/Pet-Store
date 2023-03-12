using Microsoft.AspNetCore.Mvc;
using PetStore.Services.Data;

using System.Threading.Tasks;

namespace PetStore.Web.Controllers
{
    public class ProductController : BaseController
    {
        private readonly IProductService productService;

        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            return this.View(await this.productService.GetAllProductsAsunc());
        }
    }
}

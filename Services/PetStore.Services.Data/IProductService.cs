using PetStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PetStore.Services;
namespace PetStore.Services.Data
{
    public interface IProductService
    {
        Task<ICollection<ProductDTO>> GetAllProductsWithCategoryAsunc(string categoryId = "");

        Task<ICollection<ProductDTO>> GetAllProductsWithNameAsunc(string productName = "");

        Task<ICollection<ProductDTO>> GetAllProductsAsunc();

        ProductDTO GetProductByIdAsunc(string productId = "");
    }
}

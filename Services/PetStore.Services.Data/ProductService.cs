using Microsoft.EntityFrameworkCore;
using PetStore.Data.Common.Repositories;
using PetStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.Services.Data
{
    public class ProductService : IProductService
    {
        private const string EmptyString = "";
        private readonly IDeletableEntityRepository<Product> productRepository;

        public ProductService(IDeletableEntityRepository<Product> productRepo)
        {
            this.productRepository = productRepo;
        }

        public async Task<ICollection<ProductDTO>> GetAllProductsWithCategoryAsunc(string categoryId = EmptyString)
        {
            ICollection<ProductDTO> products = new List<ProductDTO>();
            if (categoryId != EmptyString)
            {
                 products = await this.productRepository
                                            .AllAsNoTracking()
                                            .Where(p => p.CategoryId == categoryId)
                                            .Select(p => new ProductDTO(p.Name, p.Price, p.Image)
                                            {
                                                CategoryId = p.CategoryId,
                                                CategoryName = p.Category.Name,
                                            })
                                            .ToListAsync();
            }

            return products;
        }

        public async Task<ICollection<ProductDTO>> GetAllProductsWithNameAsunc(string productName = EmptyString)
        {
            ICollection<ProductDTO> products = new List<ProductDTO>();
            if (productName != EmptyString)
            {
                products = await this.productRepository
                                           .AllAsNoTracking()
                                           .Where(p => p.Name.ToLower().Contains(productName.ToLower()))
                                           .Select(p => new ProductDTO(p.Name, p.Price, p.Image)
                                           {
                                               CategoryId = p.CategoryId,
                                               CategoryName = p.Category.Name,
                                           })
                                           .ToListAsync();
            }

            return products;
        }

        public async Task<ICollection<ProductDTO>> GetAllProductsAsunc()
        {
            ICollection<ProductDTO> products = await this.productRepository
                                    .AllAsNoTracking()
                                    .Select(p => new ProductDTO(p.Name, p.Price, p.Image)
                                    {
                                        CategoryId = p.CategoryId,
                                        CategoryName = p.Category.Name,
                                    }).ToListAsync();

            return products;
        }

        public ProductDTO GetProductByIdAsunc(string productId)
        {
            ProductDTO product = this.productRepository
                                    .AllAsNoTracking().Where(p => p.Id == productId)
                                    .Select(p => new ProductDTO(p.Name, p.Price, p.Image)
                                    {
                                        CategoryId = p.CategoryId,
                                        CategoryName = p.Category.Name,
                                    })
                                    .FirstOrDefault();

            return product;
        }
    }
}

using PetStore.Data.Common.Repositories;
using PetStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

namespace PetStore.Services.Data
{
    public class CategoryService : ICategoryService
    {
        private readonly IDeletableEntityRepository<Category> categoryRepository;
        private readonly IDeletableEntityRepository<Product> productRepository;

        public CategoryService(IDeletableEntityRepository<Category> categoryRepo, IDeletableEntityRepository<Product> productRepo)
        {
            this.categoryRepository = categoryRepo;
            this.productRepository = productRepo;
        }

        public async Task<ICollection<CategoryDTO>> GetAllCategoriesAsync()
        {
            ICollection<CategoryDTO> categoryDTOs = new List<CategoryDTO>();

            categoryDTOs = await this.categoryRepository
                            .AllAsNoTracking()
                            .Select(c => new CategoryDTO(c.Id, c.Name))
                            .ToListAsync();

            return categoryDTOs;
        }
    }
}

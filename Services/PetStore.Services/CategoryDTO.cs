using PetStore.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.Services
{
    public class CategoryDTO
    {
        public CategoryDTO(string categoryId, string name)
        {
            this.CategoryId = categoryId;
            this.Name = name;
            this.ProductDTOs = new HashSet<ProductDTO>();
        }

        public string CategoryId { get; set; }

        public string Name { get; set; }

        public ICollection<Pet> Pets { get; set; }

        public ICollection<ProductDTO> ProductDTOs { get; set; }
    }
}

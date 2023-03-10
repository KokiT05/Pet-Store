using PetStore.Common;
using PetStore.Data.Common.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.Data.Models
{
    public class Category : BaseDeletableModel<string>
    {
        public Category()
        {
            this.Id = Guid.NewGuid().ToString();

            this.Pets = new HashSet<Pet>();

            this.Products = new HashSet<Product>();
        }

        [Required]
        [MaxLength(CategoryValidationConstants.NameMaxLength)]
        public string Name { get; set; }

        public ICollection<Pet> Pets { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}

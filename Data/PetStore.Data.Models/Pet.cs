using PetStore.Common;
using PetStore.Data.Common.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.Data.Models
{
    public class Pet : BaseDeletableModel<string>
    {
        public Pet()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        [MaxLength(PetValidationConstants.NameMaxLength)]
        public string? Name { get; set; }

        [Required]
        [Range(PetValidationConstants.MinAge, PetValidationConstants.MaxAge)]
        public int Age { get; set; }

        [Required]
        [MaxLength(PetValidationConstants.BreedMaxLength)]
        public string Breed { get; set; }

        [Required]
        [Range(PetValidationConstants.MinPrice, PetValidationConstants.MaxPrice)]
        public decimal Price { get; set; }

        public string Image { get; set; }

        [Required]
        [ForeignKey(nameof(Category))]
        public string CategoryId { get; set; }

        public virtual Category Category { get; set; }

        [ForeignKey(nameof(Owner))]
        public string? ClientId { get; set; }

        public virtual Client Owner { get; set; }

        [Required]
        [ForeignKey(nameof(Store))]
        public string StoreId { get; set; }

        public virtual Store Store { get; set; }
    }
}

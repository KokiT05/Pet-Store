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
    public class Product : BaseDeletableModel<string>
    {
        public Product()
        {
            this.Id = Guid.NewGuid().ToString();

            this.Stores = new HashSet<Store>();
            this.Orders = new HashSet<Order>();
        }

        [Required]
        [MaxLength(ProductValidationConstants.NameMaxLength)]
        public string Name { get; set; }

        [Required]
        [Range(ProductValidationConstants.MinPrice, ProductValidationConstants.MaxPrice)]
        public decimal Price { get; set; }

        public string Image { get; set; }

        [Required]
        [ForeignKey(nameof(Category))]
        public string CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public virtual ICollection<Store> Stores { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}

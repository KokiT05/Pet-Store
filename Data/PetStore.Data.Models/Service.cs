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
    public class Service : BaseDeletableModel<string>
    {
        public Service()
        {
            this.Id = Guid.NewGuid().ToString();

            this.Stores = new HashSet<Store>();
            this.Orders = new HashSet<Order>();
        }

        [Required]
        [MaxLength(ServiceValidationConstants.NameMaxLength)]
        public string Name { get; set; }

        [Required]
        [MaxLength(ServiceValidationConstants.DescriptionMaxLength)]
        public string Description { get; set; }

        [Required]
        [Range(ServiceValidationConstants.MinPrice, ServiceValidationConstants.MaxPrice)]
        public decimal Price { get; set; }

        public virtual ICollection<Store> Stores { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}

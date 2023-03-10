using PetStore.Data.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetStore.Data.Models.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PetStore.Common;

namespace PetStore.Data.Models
{
    public class Order : BaseDeletableModel<string>
    {
        public Order()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        [Required]
        [ForeignKey(nameof(Client))]
        public string ClientId { get; set; }

        public virtual Client Client { get; set; }

        public virtual ICollection<Product> Products { get; set; }

        public virtual ICollection<Service> Services { get; set; }

        [Required]
        public DeliveryType DeliveryType { get; set; }


        [Required]
        [Range(OrderValidationConstants.MinPrice, OrderValidationConstants.MaxPrice)]
        public decimal TotalPrice { get; set; }
    }
}

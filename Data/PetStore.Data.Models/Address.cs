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
    public class Address : BaseDeletableModel<string>
    {
        public Address()
        {
            this.Id = Guid.NewGuid().ToString();

            this.Clients = new HashSet<Client>();
        }

        [Required]
        [MaxLength(AddressValidationConstants.AddressMaxLength)]
        public string AddressText { get; set; }

        [Required]
        [MaxLength(AddressValidationConstants.TownNameMaxLength)]
        public string TownName { get; set; }

        public virtual ICollection<Client> Clients { get; set; }

        [ForeignKey(nameof(Store))]
        public string? StoreId { get; set; }

        public virtual Store Store { get; set; }
    }
}

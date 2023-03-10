using PetStore.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.Data.Models
{
    public class Client : ApplicationUser
    {
        public Client()
        {
            this.PaymentCards = new HashSet<CardInfo>();
            this.Pets = new HashSet<Pet>();
            this.Orders = new HashSet<Order>();
        }

        [Required]
        [MaxLength(ClientValidationConstants.FirstNameMaxLength)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(ClientValidationConstants.LastNameMaxLength)]
        public string LastName { get; set; }

        [ForeignKey(nameof(Address))]
        public string? AddressId { get; set; }

        public virtual Address Address { get; set; }

        [ForeignKey(nameof(ClientCard))]
        public string? ClientCardId { get; set; }

        public virtual ClientCard ClientCard { get; set; }

        public virtual ICollection<CardInfo> PaymentCards { get; set; }

        public virtual ICollection<Pet> Pets { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}

using PetStore.Common;
using PetStore.Data.Common.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.Data.Models
{
    public class ClientCard : BaseDeletableModel<string>
    {
        public ClientCard()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        [Required]
        [MaxLength(CardInfoValidationConstants.CardInfoNumberMaxLength)]
        public string CardNumber { get; set; }

        [Required]
        [MaxLength(CardInfoValidationConstants.ExpirationDateMaxLength)]
        public string ExpirationDate { get; set; }

        [Range(ClientCardValidationConstantss.DiscountMinValue, ClientCardValidationConstantss.DiscountMaxValue)]
        public double? Discount { get; set; }

        [Required]
        [ForeignKey(nameof(Client))]
        public string ClientID { get; set; }

        public virtual Client Client { get; set; }
    }
}

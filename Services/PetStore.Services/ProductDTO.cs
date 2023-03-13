using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.Services
{
    public class ProductDTO
    {
        public ProductDTO(string name, decimal price, string image)
        {
            this.Name = name;
            this.Price = price;
            this.Image = image;

        }

        public string ProductId { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Image { get; set; }

        public string CategoryId { get; set; }

        public string CategoryName { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppi_Inmar.Models
{
    public class Product
    {
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

        public Product(string ProductName, decimal Price, string Description)
        {
            this.ProductName = ProductName;
            this.Price = Price;
            this.Description = Description;
        }


    }
}
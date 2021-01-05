using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppi_Inmar.Models
{
    public class Offer
    {
        public string OfferName { get; set; }

        public IList<Product> Products { get; set; }

        Offer(string offerName, IList<Product> products)
        {
            this.OfferName = offerName;
            this.Products = products;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageFeatures.Models
{
    public class Product
    {
        public string Name { get; set; }
        public string Category { get; set; } = "Watersports";
        public decimal? Price { get; set; }
        public Product Related { get; set; }
        public bool InStock { get; } = true;

        public Product(bool stock = true)
        {
            InStock = stock;
        }

        public static Product[] GetProducts()
        {
            Product boat = new Product
            {
                Name = "Boat",
                Category = "Water Craft",
                Price = 27m
            };

            Product lifejacket = new Product(false)
            {
                Name = "Lifejacket",
                Price = 48.95M
            };

            boat.Related = lifejacket;

            return new Product[]
            {
                boat, lifejacket, null
            };
        }

    }
}

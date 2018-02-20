﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageFeatures.Models
{
    public class Product
    {
        public string Name { get; set; }
        public decimal? Price { get; set; }

        public static Product[] GetProduct()
        {
            Product boat = new Product
            {
                Name = "Boat",
                Price = 27m
            };

            Product lifejacket = new Product
            {
                Name = "Lifejacket",
                Price = 48.95M
            };

            return new Product[]
            {
                boat, lifejacket, null
            };
        }

    }
}

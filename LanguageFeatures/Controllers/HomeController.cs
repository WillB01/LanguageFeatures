using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LanguageFeatures.Models;
using Microsoft.AspNetCore.Mvc;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<string> results = new List<string>();

            foreach (Product item in Product.GetProducts())
            {
                string name = item?.Name;
                decimal? price = item?.Price;
                string relatedName = item?.Related?.Name;
                results.Add(string.Format(
                    "name: {0}, Price: {1}, Related: {2}}"
                    , name, price, relatedName));

            }
           
            return View(results);
        }
    }
}
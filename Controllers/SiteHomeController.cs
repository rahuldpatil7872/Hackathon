using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using HackathonDemo.Models;

namespace HackathonDemo.Controllers
{
    public class SiteHomeController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            var products = SetupProducts();
            return View(products);
        }

        public ActionResult GetReturnProducts()
        {
            var products = SetupProducts().Where(p => p.IsReturned);
            return View(products);
        }

        private static List<Product> SetupProducts()
        {
            var products = new List<Product>
            {
                new Product
                {
                    ProductId = 12345,
                    ProductTitle = "ASOS Knitted Swing Dress With Zip Neck",
                    Image =
                        "http://images.asos-media.com/products/asos-knitted-swing-dress-with-zip-neck/8011669-1-blue?$XXL$&amp;wid=513&amp;fit=constrain",
                    Price = 6000,
                    Colour = "Blue",
                    Details = "Body: 53% Polyester, 21% Acrylic, 20% Nylon, 6% Wool.",
                    LookAfterMe = "Machine Wash According To Instructions On Care Label",
                    Size = new List<string> {"UK 8", "UK 6"},
                    IsReturned = true
                },
                new Product
                {
                    ProductId = 12346,
                    ProductTitle = "Boohoo Tab Side Lace Maxi Dress",
                    Image =
                        "http://images.asos-media.com/products/boohoo-tab-side-lace-maxi-dress/8508300-1-peach?$XXL$&amp;wid=513&amp;fit=constrain",
                    Price = 6050,
                    Colour = "Peach",
                    Details = "Outer: 97% Polyester, 3% Elastane, Inner: 95% Viscose, 5% Elastane.",
                    LookAfterMe = "Machine Wash According To Instructions On Care Label",
                    Size = new List<string> {"UK 8", "UK 12"}
                },
                new Product
                {
                    ProductId = 12347,
                    ProductTitle = "Pimkie Floral Print Cami Dress",
                    Image =
                        "http://images.asos-media.com/products/pimkie-floral-print-cami-dress/8518510-1-bluepattern?$XXL$&amp;wid=513&amp;fit=constrain",
                    Price = 7000,
                    Colour = "Blue pattern",
                    Details = "Main: 100% Viscose.",
                    LookAfterMe = "Machine Wash According To Instructions On Care Label",
                    Size = new List<string> {"UK 10", "UK 12"}
                }
            };
            return products;
        }
    }
}
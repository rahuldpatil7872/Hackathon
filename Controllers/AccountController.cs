using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using HackathonDemo.Models;

namespace HackathonDemo.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult GetAccount(string customerName)
        {
            Account account;
            if (customerName != null)
            {
                account = new Account
                {
                    CustomerId = 1,
                    CustomerName = customerName,
                    OrderList = null,
                    ShippingAddress = "F-58, Empire Estate, Chinchwad, Maharashtra, India, 411019"
                };
            }
            else
            {
                account = new Account
               {
                   CustomerId = 1,
                   CustomerName = "Aditi",
                   OrderList = OrderProduct(),
                   ShippingAddress = "F-56, Chinchwad, Maharashtra, India, 411019"
               };
            }

            return View(account);
        }

        [HttpPost]
        public ActionResult GetAccount(Product[] products, int productId, bool isReturned)
        {
            if (products == null || !products.Any())
            {
                products = OrderProduct();
            }

            if (isReturned)
            {
                var returnedProduct = products.Where(p => p.ProductId == productId).FirstOrDefault();
                returnedProduct.IsReturned = true;
            }

            var account = new Account
            {
                CustomerId = 1,
                CustomerName = "Aditi",
                OrderList = products,
                ShippingAddress = "F-56, Chinchwad, Maharashtra, India, 411019"
            };


            return View(account);
        }

        public string OpenPopup()
        {
            return "<h1>Check exciting deals of the day for you!</h1>";
        }

        private static Product[] OrderProduct()
        {
            return new[]
            {
                new Product
                {
                    ProductId = 12345,
                    ProductTitle = "Knitted Swing Dress With Zip Neck",
                    Image =
                        "http://images.asos-media.com/products/asos-knitted-swing-dress-with-zip-neck/8011669-1-blue?$XXL$&amp;wid=513&amp;fit=constrain",
                    Price = 6000,
                    Colour = "Blue",
                    Details = "Body: 53% Polyester, 21% Acrylic, 20% Nylon, 6% Wool.",
                    LookAfterMe = "Machine Wash According To Instructions On Care Label",
                    Size = new List<string> {"UK 8", "UK 6"}
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
                }
            };
        }
    }
}
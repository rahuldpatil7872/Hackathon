using System.Collections.Generic;
using System.Web.Mvc;
using HackathonDemo.Models;

namespace HackathonDemo.Controllers
{
    public class ProductController : Controller
    {
        // GET: Bag
        public ActionResult ViewProduct(Product product)
        {
            if (product == null)
            {
                product = new Product
                {
                    ProductId = 12345,
                    ProductTitle = "Knitted Swing Dress With Zip Neck",
                    Image =
                        "http://images.asos-media.com/products/asos-knitted-swing-dress-with-zip-neck/8011669-1-blue?$XXL$&amp;wid=513&amp;fit=constrain",
                    Price = 6000,
                    Colour = "Blue",
                    Details = "Body: 53% Polyester, 21% Acrylic, 20% Nylon, 6% Wool.",
                    LookAfterMe = "Machine Wash According To Instructions On Care Label",
                    Size = new List<string> { "UK 8" },
                    IsReturned = true
                };
            }
            return View(product);
        }
    }
}
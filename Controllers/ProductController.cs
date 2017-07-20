using System.Web.Mvc;
using HackathonDemo.Models;

namespace HackathonDemo.Controllers
{
    public class ProductController : Controller
    {
        // GET: Bag
        public ActionResult ViewProduct(Product product)
        {
            return View(product);
        }
    }
}
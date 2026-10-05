using practical6.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace practical6.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Index()
        {
            List<Product> products = new List<Product>()
            {
                new Product
                {
                    Id = 1,
                    Name = "Laptop",
                    Category = "Electronics",
                    Price = 50000
                },

                new Product
                {
                    Id = 2,
                    Name = "Mouse",
                    Category = "Accessories",
                    Price = 500
                },

                new Product
                {
                    Id = 3,
                    Name = "Keyboard",
                    Category = "Accessories",
                    Price = 1000
                },

                new Product
                {
                    Id = 4,
                    Name = "Mobile",
                    Category = "Electronics",
                    Price = 25000
                }
            };

            return View(products);
        }
    }
}

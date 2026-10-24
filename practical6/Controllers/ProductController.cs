
using System.Collections.Generic;
using System.Web.Mvc;
using practical6.Models;

namespace practical6.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Index()
        {
            List<Product> products = new List<Product>
            {
                new Product { Id = 1, Name = "Laptop",
                    Category = "Electronics", Price = 55000,
                    Description = "High-performance laptop" },

                new Product { Id = 2, Name = "Smartphone",
                    Category = "Electronics", Price = 25000,
                    Description = "Latest smartphone" },

                new Product { Id = 3, Name = "Headphones",
                    Category = "Accessories", Price = 1500,
                    Description = "Wireless headphones" }
            };

            return View(products);
        }
    }
}

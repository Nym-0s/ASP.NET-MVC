using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            List<Product> products = new List<Product>
            {
                new Product { Id = 1, Name = "Product 1", Price = 6.99m, Description = "Description of Product 1" },
                new Product { Id = 2, Name = "Product 2", Price = 2.35m, Description = "Description of Product 2" },
                new Product { Id = 3, Name = "Product 3", Price = 15.99m, Description = "Description of Product 3" }
            };

            return View(products as IEnumerable<Product>);
        }

    }
}
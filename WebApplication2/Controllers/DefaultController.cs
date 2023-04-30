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
                new Product { Id = 1, Name = "Table", Price = 6.99m, Description = "Just good table" },
                new Product { Id = 2, Name = "Backpack", Price = 2.35m, Description = "For all your good stuff" },
                new Product { Id = 3, Name = "Notebook", Price = 15.99m, Description = "Good for study, but not for gaming" }
            };

            return View(products as IEnumerable<Product>);
        }

    }
}

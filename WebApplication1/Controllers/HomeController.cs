using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            int firstVal = 10;
            int secondVal = 0;
            int result = firstVal / secondVal;

            // Этот оператор закомментирован
            // ViewBag.Message = "Отладка приложения ASP.NET MVC!";

            return View(result);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_MVC_app.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            //ViewBag.Message = "Your contact page.";
            int suma = 1 + 1;
            ViewBag.Message = "Suma: " + suma;
            return View();
        }

        public ActionResult Adoptar()
        {
            ViewBag.Message = "Encuentra el libro que necesitas: ";
            return View();
        }
    }
}
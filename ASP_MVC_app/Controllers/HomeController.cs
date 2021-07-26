using ASP_MVC_app.Models;
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
            ViewBag.Message = "Registra una mascota para darla en adopción.";
            return View();
        }

        [HttpPost]
        public ActionResult Contact(Libro libro)
        {
            try
            {
                // ModelState: colección de pares de nombre y valor que se enviaron al servidor durante una POST.
                if (ModelState.IsValid)
                {
                    DAL.Libro sdb = new DAL.Libro();
                    if (sdb.AgregarLibro(libro))
                    {
                        ViewBag.Message = "Gracias por registrar la obra: " + libro.Nombre;
                        ModelState.Clear();
                    }
                }
                return View();
            }
            catch
            {
                ViewBag.Message = "Error al registrar mascota";
                return View();
            }
        }
        public ActionResult Adoptar()
        {
            ViewBag.Message = "Encuentra el libro que necesitas: ";
            return View();
        }
    }
}
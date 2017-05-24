using ProyectoRespaldo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoRespaldo.Controllers
{
    public class HomeController : Controller
    {
        List<Informacion> datos = new List<Informacion>();

        public HomeController()
        {
            datos.Add(new Informacion("Jose", "Rios2", 19, true, DateTime.Now.Date));
            datos.Add(new Informacion("Josex", "Rios2", 25, true, DateTime.Now.Date));
            datos.Add(new Informacion("Joset", "Rios3", 36, false, DateTime.Now.Date));
            datos.Add(new Informacion("Joser", "Rios4", 47, true, DateTime.Now.Date));
            datos.Add(new Informacion("Joset", "Rios4", 58, false, DateTime.Now.Date));
            datos.Add(new Informacion("Joseq", "Rios5", 67, false, DateTime.Now.Date));

        }
        public ActionResult Index()
        {
            return View(datos);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
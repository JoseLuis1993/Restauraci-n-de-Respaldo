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
            datos.Add(new Informacion("MV1", "Servidor 1", 19, true, DateTime.Now.Date));
            datos.Add(new Informacion("MV2", "Servidor 2", 25, true, DateTime.Now.Date));
            datos.Add(new Informacion("MV3", "Servidor 3", 36, false, DateTime.Now.Date));
            datos.Add(new Informacion("MV4", "Servidor 4", 47, true, DateTime.Now.Date));
            datos.Add(new Informacion("MV5", "Servidor 5", 58, false, DateTime.Now.Date));
            datos.Add(new Informacion("MV6", "Servidor 6", 67, false, DateTime.Now.Date));

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
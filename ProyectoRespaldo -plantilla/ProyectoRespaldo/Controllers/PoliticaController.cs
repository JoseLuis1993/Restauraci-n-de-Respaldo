using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProyectoRespaldo.Models;

namespace ProyectoRespaldo.Controllers
{
    public class PoliticaController : Controller
    {
        List<Informacion> datos = new List<Informacion>();

        public PoliticaController()
        {
            datos.Add(new Informacion("Jose", "Rios2", 19, true, DateTime.Now.Date));
            datos.Add(new Informacion("Josex", "Rios2", 25, true, DateTime.Now.Date));
            datos.Add(new Informacion("Joset", "Rios3", 36, false, DateTime.Now.Date));
            datos.Add(new Informacion("Joser", "Rios4", 47, true, DateTime.Now.Date));
            datos.Add(new Informacion("Joset", "Rios4", 58, false, DateTime.Now.Date));
            datos.Add(new Informacion("Joseq", "Rios5", 67, false, DateTime.Now.Date));

        }

        // GET: Politica
        public ActionResult Index_Politica()
        {
            return View(datos);
        }

        public ActionResult AsignPolitica()
        {
            return View();
        }

        // GET: Politica/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Politica/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Politica/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Politica/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Politica/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Politica/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Politica/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

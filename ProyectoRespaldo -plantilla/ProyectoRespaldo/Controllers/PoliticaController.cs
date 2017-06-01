using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProyectoRespaldo.Models;
using System.Net;
using System.Data.Entity;

namespace ProyectoRespaldo.Controllers
{
    public class PoliticaController : Controller
    {
        private RespaldosEntities db = new RespaldosEntities();
        
        // GET: Politica
        public ActionResult Index_Politica()
        {
            return View(db.politica.ToList());
        }

        public ActionResult AsignPolitica(string theName)
        {
            char delimitador = ',';
            string[] nuevo = theName.Split(delimitador);

            List<string> listaMaquina = new List<string>();

            for (int i = 0; i < nuevo.Length; i++)
                listaMaquina.Add(nuevo[i]);

            ViewData["ListaM"] = listaMaquina;

            return View(db.politica.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        // POST: politicas/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_politica,nombre,fecha_fin,hora_inicio,hora_fin,ruta_almacenamiento,frecuencia_sem,num_respaldos,dias,politica_default")] politica politica)
        {
            if (ModelState.IsValid)
            {
                db.politica.Add(politica);
                db.SaveChanges();
                return RedirectToAction("Index_Politica");
            }

            return View(politica);
        }

        // GET: politicas/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            politica politica = db.politica.Find(id);
            if (politica == null)
            {
                return HttpNotFound();
            }

            return View(politica);
        }

        // GET: politicas/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            politica politica = db.politica.Find(id);
            if (politica == null)
            {
                return HttpNotFound();
            }
            return View(politica);
        }

        // POST: politicas/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_politica,nombre,fecha_fin,hora_inicio,hora_fin,ruta_almacenamiento,frecuencia_sem,num_respaldos,dias,politica_default")] politica politica)
        {
            if (ModelState.IsValid)
            {
                db.Entry(politica).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index_Politica");
            }
            return View(politica);
        }

        // GET: politicas/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            politica politica = db.politica.Find(id);
            if (politica == null)
            {
                return HttpNotFound();
            }
            return View(politica);
        }

        // POST: politicas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            politica politica = db.politica.Find(id);
            db.politica.Remove(politica);
            db.SaveChanges();
            return RedirectToAction("Index_Politica");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProyectoRespaldo.Models;

namespace ProyectoRespaldo.Controllers
{
    public class politicasController : Controller
    {
        private RespaldosEntities db = new RespaldosEntities();

        // GET: politicas
        public ActionResult Index()
        {
            return View(db.politica.ToList());
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

        // GET: politicas/Create
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
                return RedirectToAction("Index");
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
                return RedirectToAction("Index");
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
            return RedirectToAction("Index");
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

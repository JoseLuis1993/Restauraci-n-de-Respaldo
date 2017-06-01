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
    public class maquina_virtualController : Controller
    {
        private RespaldosEntities1 db = new RespaldosEntities1();

        // GET: maquina_virtual
        public ActionResult Index()
        {
            var maquina_virtual = db.maquina_virtual.Include(m => m.servidor);
            return View(maquina_virtual.ToList());
        }

        // GET: maquina_virtual/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            maquina_virtual maquina_virtual = db.maquina_virtual.Find(id);
            if (maquina_virtual == null)
            {
                return HttpNotFound();
            }
            return View(maquina_virtual);
        }

        // GET: maquina_virtual/Create
        public ActionResult Create()
        {
            ViewBag.id_servidor = new SelectList(db.servidor, "id_servidor", "nombre");
            return View();
        }

        // POST: maquina_virtual/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id_maquina,id_servidor,nombre,estatus,direccion_ip,prioridad,grupo")] maquina_virtual maquina_virtual)
        {
            if (ModelState.IsValid)
            {
                db.maquina_virtual.Add(maquina_virtual);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.id_servidor = new SelectList(db.servidor, "id_servidor", "nombre", maquina_virtual.id_servidor);
            return View(maquina_virtual);
        }

        // GET: maquina_virtual/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            maquina_virtual maquina_virtual = db.maquina_virtual.Find(id);
            if (maquina_virtual == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_servidor = new SelectList(db.servidor, "id_servidor", "nombre", maquina_virtual.id_servidor);
            return View(maquina_virtual);
        }

        // POST: maquina_virtual/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id_maquina,id_servidor,nombre,estatus,direccion_ip,prioridad,grupo")] maquina_virtual maquina_virtual)
        {
            if (ModelState.IsValid)
            {
                db.Entry(maquina_virtual).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.id_servidor = new SelectList(db.servidor, "id_servidor", "nombre", maquina_virtual.id_servidor);
            return View(maquina_virtual);
        }

        // GET: maquina_virtual/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            maquina_virtual maquina_virtual = db.maquina_virtual.Find(id);
            if (maquina_virtual == null)
            {
                return HttpNotFound();
            }
            return View(maquina_virtual);
        }

        // POST: maquina_virtual/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            maquina_virtual maquina_virtual = db.maquina_virtual.Find(id);
            db.maquina_virtual.Remove(maquina_virtual);
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

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
    public class MVirtualController : Controller
    {
        private RespaldosEntities db = new RespaldosEntities();
        

        // GET: MVirtual
        public ActionResult Index_MVirtual()
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

    }
}

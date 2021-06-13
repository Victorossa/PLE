using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GeneradorCodigoAdm.Models;

namespace GeneradorCodigoAdm.Controllers
{
    public class tecn_bloque_codigoController : Controller
    {
        private DBModel db = new DBModel();

        // GET: tecn_bloque_codigo
        public ActionResult Index()
        {
            var tecn_bloque_codigo = db.tecn_bloque_codigo.Include(t => t.tecn_tecnologias);
            return View(tecn_bloque_codigo.ToList());
        }

        // GET: tecn_bloque_codigo/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tecn_bloque_codigo tecn_bloque_codigo = db.tecn_bloque_codigo.Find(id);
            if (tecn_bloque_codigo == null)
            {
                return HttpNotFound();
            }
            return View(tecn_bloque_codigo);
        }

        // GET: tecn_bloque_codigo/Create
        public ActionResult Create()
        {
            ViewBag.TecnologiaID = new SelectList(db.tecn_tecnologias, "TecnologiaID", "NombreTecnologia");
            return View();
        }

        // POST: tecn_bloque_codigo/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BloqueID,TecnologiaID,NombreBloque,Contenido")] tecn_bloque_codigo tecn_bloque_codigo)
        {
            if (ModelState.IsValid)
            {
                db.tecn_bloque_codigo.Add(tecn_bloque_codigo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.TecnologiaID = new SelectList(db.tecn_tecnologias, "TecnologiaID", "NombreTecnologia", tecn_bloque_codigo.TecnologiaID);
            return View(tecn_bloque_codigo);
        }

        // GET: tecn_bloque_codigo/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tecn_bloque_codigo tecn_bloque_codigo = db.tecn_bloque_codigo.Find(id);
            if (tecn_bloque_codigo == null)
            {
                return HttpNotFound();
            }
            ViewBag.TecnologiaID = new SelectList(db.tecn_tecnologias, "TecnologiaID", "NombreTecnologia", tecn_bloque_codigo.TecnologiaID);
            return View(tecn_bloque_codigo);
        }

        // POST: tecn_bloque_codigo/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BloqueID,TecnologiaID,NombreBloque,Contenido")] tecn_bloque_codigo tecn_bloque_codigo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tecn_bloque_codigo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.TecnologiaID = new SelectList(db.tecn_tecnologias, "TecnologiaID", "NombreTecnologia", tecn_bloque_codigo.TecnologiaID);
            return View(tecn_bloque_codigo);
        }

        // GET: tecn_bloque_codigo/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tecn_bloque_codigo tecn_bloque_codigo = db.tecn_bloque_codigo.Find(id);
            if (tecn_bloque_codigo == null)
            {
                return HttpNotFound();
            }
            return View(tecn_bloque_codigo);
        }

        // POST: tecn_bloque_codigo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tecn_bloque_codigo tecn_bloque_codigo = db.tecn_bloque_codigo.Find(id);
            db.tecn_bloque_codigo.Remove(tecn_bloque_codigo);
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

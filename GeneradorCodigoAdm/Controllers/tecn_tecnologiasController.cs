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
    public class tecn_tecnologiasController : Controller
    {
        private DBModel db = new DBModel();

        // GET: tecn_tecnologias
        public ActionResult Index()
        {
            return View(db.tecn_tecnologias.ToList());
        }

        // GET: tecn_tecnologias/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tecn_tecnologias tecn_tecnologias = db.tecn_tecnologias.Find(id);
            if (tecn_tecnologias == null)
            {
                return HttpNotFound();
            }
            return View(tecn_tecnologias);
        }

        // GET: tecn_tecnologias/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tecn_tecnologias/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TecnologiaID,NombreTecnologia")] tecn_tecnologias tecn_tecnologias)
        {
            if (ModelState.IsValid)
            {
                db.tecn_tecnologias.Add(tecn_tecnologias);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tecn_tecnologias);
        }

        // GET: tecn_tecnologias/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tecn_tecnologias tecn_tecnologias = db.tecn_tecnologias.Find(id);
            if (tecn_tecnologias == null)
            {
                return HttpNotFound();
            }
            return View(tecn_tecnologias);
        }

        // POST: tecn_tecnologias/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TecnologiaID,NombreTecnologia")] tecn_tecnologias tecn_tecnologias)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tecn_tecnologias).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tecn_tecnologias);
        }

        // GET: tecn_tecnologias/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tecn_tecnologias tecn_tecnologias = db.tecn_tecnologias.Find(id);
            if (tecn_tecnologias == null)
            {
                return HttpNotFound();
            }
            return View(tecn_tecnologias);
        }

        // POST: tecn_tecnologias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tecn_tecnologias tecn_tecnologias = db.tecn_tecnologias.Find(id);
            db.tecn_tecnologias.Remove(tecn_tecnologias);
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

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TURIWEBMty.Content;
using TURIWEBMty.Models;

namespace TURIWEBMty.Controllers
{
    public class logios1Controller : Controller
    {
        private TuriContext db = new TuriContext();

        // GET: logios
        public ActionResult Index()
        {
            return View();
        }

        // GET: logios/Details/5
        public ActionResult Details(string Nombre, string Contraseña)
        { 
            var a = (from b in db.login
                     where b.Correo == Nombre && b.Contraseña == Contraseña
                     select b).Count();
            if (a > 0)
            {
                return View("Index", "Principal");
            }
            else
            {
                return View("Index", "logios1");
            }
        }

        // GET: logios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: logios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Nombre,Correo,Contraseña")] logio logio)
        {
            if (ModelState.IsValid)
            {
                db.login.Add(logio);
                db.SaveChanges();
                return RedirectToAction("Index", "logios1");
            }

            return View(logio);
        }

        // GET: logios/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            logio logio = db.login.Find(id);
            if (logio == null)
            {
                return HttpNotFound();
            }
            return View(logio);
        }

        // POST: logios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Nombre,Correo,Contraseña")] logio logio)
        {
            if (ModelState.IsValid)
            {
                db.Entry(logio).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(logio);
        }

        // GET: logios/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            logio logio = db.login.Find(id);
            if (logio == null)
            {
                return HttpNotFound();
            }
            return View(logio);
        }

        // POST: logios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            logio logio = db.login.Find(id);
            db.login.Remove(logio);
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

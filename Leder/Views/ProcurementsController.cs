using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Leder.Models;

namespace Leder.Views
{
    public class ProcurementsController : Controller
    {
        private LederContext db = new LederContext();

        // GET: Procurements
        public ActionResult Index()
        {
            var procurement = db.Procurement.Include(p => p.Product);
            return View(procurement.ToList());
        }

        // GET: Procurements/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Procurement procurement = db.Procurement.Find(id);
            if (procurement == null)
            {
                return HttpNotFound();
            }
            return View(procurement);
        }

        // GET: Procurements/Create
        public ActionResult Create()
        {
            ViewBag.ProductId = new SelectList(db.Products, "ProductId", "Name");
            return View();
        }

        // POST: Procurements/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProcurementId,ProductId,PurchaseDate,Quantity,UnitPrize")] Procurement procurement)
        {
            if (ModelState.IsValid)
            {
                db.Procurement.Add(procurement);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ProductId = new SelectList(db.Products, "ProductId", "Name", procurement.ProductId);
            return View(procurement);
        }

        // GET: Procurements/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Procurement procurement = db.Procurement.Find(id);
            if (procurement == null)
            {
                return HttpNotFound();
            }
            ViewBag.ProductId = new SelectList(db.Products, "ProductId", "Name", procurement.ProductId);
            return View(procurement);
        }

        // POST: Procurements/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProcurementId,ProductId,PurchaseDate,Quantity,UnitPrize")] Procurement procurement)
        {
            if (ModelState.IsValid)
            {
                db.Entry(procurement).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ProductId = new SelectList(db.Products, "ProductId", "Name", procurement.ProductId);
            return View(procurement);
        }

        // GET: Procurements/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Procurement procurement = db.Procurement.Find(id);
            if (procurement == null)
            {
                return HttpNotFound();
            }
            return View(procurement);
        }

        // POST: Procurements/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Procurement procurement = db.Procurement.Find(id);
            db.Procurement.Remove(procurement);
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

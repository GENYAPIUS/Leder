using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Leder.Models;

namespace Leder.Controllers
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
                var product = db.Products.Find(procurement.ProductId);
                db.Procurement.Add(procurement);
                product.UnitInStock += procurement.Quantity;
                db.Entry(product).State = EntityState.Modified;
              
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
                var product = db.Products.Find(procurement.ProductId);
                ChangeProductUnitStock(product,procurement);
                db.Entry(procurement).State = EntityState.Added;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ProductId = new SelectList(db.Products, "ProductId", "Name", procurement.ProductId);
            return View(procurement);
        }

        public void ChangeProductUnitStock([Bind(Include = "UnitInStock")] Product product,Procurement procurement) {
            if (ModelState.IsValid)
            {
                Procurement originProcurement = db.Procurement.Find(procurement.ProcurementId);
                product.UnitInStock += (procurement.Quantity - originProcurement.Quantity);
                db.Entry(originProcurement).State = EntityState.Deleted;
                db.Entry(product).State = EntityState.Modified;
            }
            return;
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

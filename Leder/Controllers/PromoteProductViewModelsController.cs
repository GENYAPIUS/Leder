using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Leder.Models;
using Leder.ViewModels;

namespace Leder.Controllers
{
    public class PromoteProductViewModelsController : Controller
    {
        private LederContext db = new LederContext();

        // GET: PromoteProductViewModels
        public ActionResult Index()
        {
            return View(db.PromoteProductViewModels.ToList());
        }

        // GET: PromoteProductViewModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PromoteProductViewModel promoteProductViewModel = db.PromoteProductViewModels.Find(id);
            if (promoteProductViewModel == null)
            {
                return HttpNotFound();
            }
            return View(promoteProductViewModel);
        }

        // GET: PromoteProductViewModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PromoteProductViewModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Section,ProductName,PhotoUrl,DiscountWord,Statement")] PromoteProductViewModel promoteProductViewModel)
        {
            if (ModelState.IsValid)
            {
                db.PromoteProductViewModels.Add(promoteProductViewModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(promoteProductViewModel);
        }

        // GET: PromoteProductViewModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PromoteProductViewModel promoteProductViewModel = db.PromoteProductViewModels.Find(id);
            if (promoteProductViewModel == null)
            {
                return HttpNotFound();
            }
            return View(promoteProductViewModel);
        }

        // POST: PromoteProductViewModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Section,ProductName,PhotoUrl,DiscountWord,Statement")] PromoteProductViewModel promoteProductViewModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(promoteProductViewModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(promoteProductViewModel);
        }

        // GET: PromoteProductViewModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PromoteProductViewModel promoteProductViewModel = db.PromoteProductViewModels.Find(id);
            if (promoteProductViewModel == null)
            {
                return HttpNotFound();
            }
            return View(promoteProductViewModel);
        }

        // POST: PromoteProductViewModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PromoteProductViewModel promoteProductViewModel = db.PromoteProductViewModels.Find(id);
            db.PromoteProductViewModels.Remove(promoteProductViewModel);
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

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Leder.Models;

namespace Leder.Controllers
{
    public class ProductsScaffoldController : Controller
    {
        private ProductContext db = new ProductContext();

        // GET: ProductsScaffold
        public ActionResult Index()
        {
            List<Product> totebags = new List<Product>
            {
                new Product{ Id =1, Name = "Clarte 流蘇迷你箱型包", Category="Totebag", Photo="Totebag1.jpg"},
                new Product{ Id =2, Name = "Diario 迷你隨行斜肩袋", Category="Totebag", Photo="Totebag2.jpg"},
                new Product{ Id =3, Name = "Plota 防水兩用斜背包", Category="Totebag", Photo="Totebag3.jpg"},
                new Product{ Id =4, Name = "Tone Oilnume 兩用托特包", Category="Totebag", Photo="Totebag4.jpg"},
                new Product{ Id =5, Name = "Tone Oilnume 拉鍊斜背包", Category="Totebag", Photo="Totebag5.jpg"},
                new Product{ Id =6, Name = "Tone Oilnume 迷你郵差包", Category="Totebag", Photo="Totebag6.jpg"},
            };



            return View(db.Products.ToList());
        }

        // GET: ProductsScaffold/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // GET: ProductsScaffold/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductsScaffold/Create
        // 若要免於過量張貼攻擊，請啟用想要繫結的特定屬性，如需
        // 詳細資訊，請參閱 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Price,Category,Photo,ProductPage")] Product product)
        {
            if (ModelState.IsValid)
            {
                db.Products.Add(product);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(product);
        }

        // GET: ProductsScaffold/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST: ProductsScaffold/Edit/5
        // 若要免於過量張貼攻擊，請啟用想要繫結的特定屬性，如需
        // 詳細資訊，請參閱 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Price,Category,Photo,ProductPage")] Product product)
        {
            if (ModelState.IsValid)
            {
                db.Entry(product).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(product);
        }

        // GET: ProductsScaffold/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST: ProductsScaffold/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Product product = db.Products.Find(id);
            db.Products.Remove(product);
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

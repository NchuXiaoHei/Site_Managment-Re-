using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Site_Managment_Re_.Models;

namespace Site_Managment_Re_.Controllers
{
    public class SiteesController : Controller
    {
        private Site_Managment_Re_Context db = new Site_Managment_Re_Context();

        // GET: Sitees
        public ActionResult Index()
        {
            return View(db.Sitees.ToList());
        }

        // GET: Sitees/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sitee sitee = db.Sitees.Find(id);
            if (sitee == null)
            {
                return HttpNotFound();
            }
            return View(sitee);
        }

        // GET: Sitees/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Sitees/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Site_name,Site_status,Note")] Sitee sitee)
        {
            if (ModelState.IsValid)
            {
                db.Sitees.Add(sitee);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sitee);
        }

        // GET: Sitees/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sitee sitee = db.Sitees.Find(id);
            if (sitee == null)
            {
                return HttpNotFound();
            }
            return View(sitee);
        }

        // POST: Sitees/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Site_name,Site_status,Note")] Sitee sitee)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sitee).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sitee);
        }

        // GET: Sitees/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sitee sitee = db.Sitees.Find(id);
            if (sitee == null)
            {
                return HttpNotFound();
            }
            return View(sitee);
        }

        // POST: Sitees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Sitee sitee = db.Sitees.Find(id);
            db.Sitees.Remove(sitee);
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

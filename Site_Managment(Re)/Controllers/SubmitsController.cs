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
    public class SubmitsController : Controller
    {
        private Site_Managment_Re_Context db = new Site_Managment_Re_Context();

        // GET: Submits
        public ActionResult Index()
        {
            return View(db.Submits.ToList());
        }

        // GET: Submits/Details/5
        public ActionResult Details(string id, string Datee, string S_time)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Submit submit = db.Submits.Find(id, Datee, S_time);
            if (submit == null)
            {
                return HttpNotFound();
            }
            return View(submit);
        }

        // GET: Submits/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Submits/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Per_ID,Per_name,Telephone,Site_name,Datee,S_time,E_time,Note")] Submit submit)
        {
            if (ModelState.IsValid)
            {
                db.Submits.Add(submit);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(submit);
        }

        // GET: Submits/Edit/5
        public ActionResult Edit(string id, string Datee,string S_time)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Submit submit = db.Submits.Find(id,Datee,S_time);
            if (submit == null)
            {
                return HttpNotFound();
            }
            return View(submit);
        }

        // POST: Submits/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Per_ID,Per_name,Telephone,Site_name,Datee,S_time,E_time,Note")] Submit submit)
        {
            if (ModelState.IsValid)
            {
                db.Entry(submit).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(submit);
        }

        // GET: Submits/Delete/5
        public ActionResult Delete(string id, string Datee, string S_time)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Submit submit = db.Submits.Find(id, Datee, S_time);
            if (submit == null)
            {
                return HttpNotFound();
            }
            return View(submit);
        }

        // POST: Submits/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id, string Datee, string S_time)
        {
            Submit submit = db.Submits.Find(id,Datee,S_time);
            db.Submits.Remove(submit);
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

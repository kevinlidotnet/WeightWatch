using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplicationSnow.Models;
using MvcApplicationSnow.DAL;

namespace MvcApplicationSnow.Controllers
{
    public class WeightController : Controller
    {
        private SnowContext db = new SnowContext();

        //
        // GET: /Weight/

        public ActionResult Index()
        {
            return View(db.Weights.ToList());
        }

        //
        // GET: /Weight/Details/5

        public ActionResult Details(int id = 0)
        {
            Weight weight = db.Weights.Find(id);
            if (weight == null)
            {
                return HttpNotFound();
            }
            return View(weight);
        }

        //
        // GET: /Weight/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Weight/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Weight weight)
        {
            if (ModelState.IsValid)
            {
                db.Weights.Add(weight);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(weight);
        }

        //
        // GET: /Weight/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Weight weight = db.Weights.Find(id);
            if (weight == null)
            {
                return HttpNotFound();
            }
            return View(weight);
        }

        //
        // POST: /Weight/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Weight weight)
        {
            if (ModelState.IsValid)
            {
                db.Entry(weight).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(weight);
        }

        //
        // GET: /Weight/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Weight weight = db.Weights.Find(id);
            if (weight == null)
            {
                return HttpNotFound();
            }
            return View(weight);
        }

        //
        // POST: /Weight/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Weight weight = db.Weights.Find(id);
            db.Weights.Remove(weight);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}
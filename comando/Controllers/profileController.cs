using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using comando.Models;

namespace comando.Controllers
{
    public class profileController : Controller
    {
        private modeloDbContext db = new modeloDbContext();

        //
        // GET: /profile/

        public ActionResult Index()
        {
            return View(db.profiles.ToList());
        }

        //
        // GET: /profile/Details/5

        public ActionResult Details(int id = 0)
        {
            profile profile = db.profiles.Find(id);
            if (profile == null)
            {
                return HttpNotFound();
            }
            return View(profile);
        }

        //
        // GET: /profile/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /profile/Create

        [HttpPost]
        public ActionResult Create(profile profile)
        {
            if (ModelState.IsValid)
            {
                db.profiles.Add(profile);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(profile);
        }

        //
        // GET: /profile/Edit/5

        public ActionResult Edit(int id = 0)
        {
            profile profile = db.profiles.Find(id);
            if (profile == null)
            {
                return HttpNotFound();
            }
            return View(profile);
        }

        //
        // POST: /profile/Edit/5

        [HttpPost]
        public ActionResult Edit(profile profile)
        {
            if (ModelState.IsValid)
            {
                db.Entry(profile).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(profile);
        }

        //
        // GET: /profile/Delete/5

        public ActionResult Delete(int id = 0)
        {
            profile profile = db.profiles.Find(id);
            if (profile == null)
            {
                return HttpNotFound();
            }
            return View(profile);
        }

        //
        // POST: /profile/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            profile profile = db.profiles.Find(id);
            db.profiles.Remove(profile);
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
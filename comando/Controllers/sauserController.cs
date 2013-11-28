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
    public class sauserController : Controller
    {
        private modeloDbContext db = new modeloDbContext();

        //
        // GET: /sauser/

        public ActionResult Index()
        {
            return View(db.users.ToList());
        }

        //
        // GET: /sauser/Details/5

        public ActionResult Details(int id = 0)
        {
            user user = db.users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        //
        // GET: /sauser/Create

        public ActionResult Create()
        {
          //db.Database.SqlQuery
         ///   ViewData["listaRoles"] = db.users.Select("Select name ");
        // var rolList = new SelectList(new[] { new { ID = "1", Name = "Super Administrador" }, new { ID = "2", Name = "Administrador" }, new { ID = "3", Name = "Operador" }, new { ID = "4", Name = "Mayorista" }, new { ID = "5", Name = "Cliente" }, }, "ID", "Name", 1);
          //  var statusList = new SelectList(new[] { new { ID = "0", Name = "Desactivado" }, new { ID = "1", Name = "Activado" }, }, "ID", "Name", 0);
         //ViewData["rolList"] = rolList;
            //ViewData["list1"] = statusList;
            return View();
        }

        //
        // POST: /sauser/Create

        [HttpPost]
        public ActionResult Create(user user)
        {
            /*
               1 Super Administrador 
             * 2 Administrador 
             * 3 Operador 
             * 4 Mayorista
             * 5 Cliente
             
             */
            Datos dat = new Datos();
            int tmp = Convert.ToInt16(Request.Form["rolList"]);
            user.rolid = dat.getID(tmp);
            // user.status = Convert.ToInt16(Request.Form["list1"]);
             if (tmp == 1)
             {
                 user.isSA = 1;
             }
             else
             {
                 user.isSA = 0;
             }
          
            if (ModelState.IsValid)
          {
          db.users.Add(user);
          db.SaveChanges();
          return RedirectToAction("Index");
          }

            return View(user);
        }

        //
        // GET: /sauser/Edit/5

        public ActionResult Edit(int id = 0)
        {
            user user = db.users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        //
        // POST: /sauser/Edit/5

        [HttpPost]
        public ActionResult Edit(user user)
        {
            Datos dat = new Datos();
            int tmp = Convert.ToInt16(Request.Form["rolList"]);
            user.rolid = dat.getID(tmp);
            // user.status = Convert.ToInt16(Request.Form["list1"]);
            if (tmp == 1)
            {
                user.isSA = 1;
            }
            else
            {
                user.isSA = 0;
            }
          
            if (ModelState.IsValid)
            {
                db.Entry(user).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(user);
        }

        //
        // GET: /sauser/Delete/5

        public ActionResult Delete(int id = 0)
        {
            user user = db.users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        //
        // POST: /sauser/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            user user = db.users.Find(id);
            db.users.Remove(user);
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
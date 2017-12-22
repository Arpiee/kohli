using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Assignment2084_2.Models;

namespace Assignment2084_2.Controllers
{
    [Authorize(Roles = "Administrator")]
        
    public class arpitphonesController : Controller
    {
        // db connection moved to Models/EFarpitphonesRepository.cs
        // private Model1 db = new Model1();
        private IarpitphonesRepository db;

        // if no mock specified, use db

            public arpitphonesController()
        {
            this.db = new EFarpitphonesRepository();
        }

        // if we tell the controller we are testing, use the mock data interface
        public arpitphonesController(IarpitphonesRepository db)

        {
            this.db = db;
        }

        // GET: arpitphones
        public ActionResult Index()
        {
            return View(db.arpitphones.ToList());
        }

        // GET: arpitphones/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            arpitphone arpitphones = db.arpitphones.Find(id);
            if (arpitphones == null)
            {
                return HttpNotFound();
            }
            return View(arpitphones);
        }

        // GET: arpitphones/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: arpitphones/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "s_no,Phone,models,Price")] arpitphone arpitphone)
        {
            if (ModelState.IsValid)
            {
                db.arpitphones.Add(arpitphone);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(arpitphone);
        }

        // GET: arpitphones/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            arpitphone arpitphone = db.arpitphones.Find(id);
            if (arpitphone == null)
            {
                return HttpNotFound();
            }
            return View(arpitphone);
        }
        [AllowAnonymous]

        // POST: arpitphones/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
       // [HttpPost]
       // [ValidateAntiForgeryToken]
       // public ActionResult Edit([Bind(Include = "s_no,Phone,models,Price")] arpitphone arpitphone)
        //{
         //   if (ModelState.IsValid)
          //  {
           //     db.Entry(arpitphone).State = EntityState.Modified;
           //     db.SaveChanges();
           //     return RedirectToAction("Index");
           // }
          //  return View(arpitphone);
       // }

        // GET: arpitphones/Delete/5
       // public ActionResult Delete(int? id)
       // {
        //    if (id == null)
          //  {
          //      return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
          //  }
          //  arpitphone arpitphone = db.arpitphones.Find(id);
         //   if (arpitphone == null)
         //   {
          //      return HttpNotFound();
          //  }
          //  return View(arpitphone);
       // }

        // POST: arpitphones/Delete/5
        //[HttpPost, ActionName("Delete")]
       // [ValidateAntiForgeryToken]
       // public ActionResult DeleteConfirmed(int id)
       // {
        //    arpitphone arpitphone = db.arpitphones.Find(id);
         //   db.arpitphones.Remove(arpitphone);
         //   db.SaveChanges();
         //   return RedirectToAction("Index");
       // }

       // protected override void Dispose(bool disposing)
       // {
         //   if (disposing)
         //   {
          //      db.Dispose();
           // }
           // base.Dispose(disposing);
        //}
    }
}

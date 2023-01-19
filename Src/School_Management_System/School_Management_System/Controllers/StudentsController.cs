using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using School_Management_System.Models;

namespace School_Management_System.Controllers
{
    public class StudentsController : Controller
    {
        private StudentDatabase db = new StudentDatabase();

        // GET: Students
        public ActionResult Index()
        {
            return View(db.tbl_Students.ToList());
        }

        // GET: Students/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_Students tbl_Students = db.tbl_Students.Find(id);
            if (tbl_Students == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Students);
        }

        // GET: Students/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Students/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "StudentID,Registration_No,Roll_No,Student_Name,Father_Name,Student_Contact,Father_Contact,Class_Name,Email,Age,Address")] tbl_Students tbl_Students)
        {
            if (ModelState.IsValid)
            {
                db.tbl_Students.Add(tbl_Students);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tbl_Students);
        }

        // GET: Students/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_Students tbl_Students = db.tbl_Students.Find(id);
            if (tbl_Students == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Students);
        }

        // POST: Students/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "StudentID,Registration_No,Roll_No,Student_Name,Father_Name,Student_Contact,Father_Contact,Class_Name,Email,Age,Address")] tbl_Students tbl_Students)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbl_Students).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tbl_Students);
        }

        // GET: Students/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_Students tbl_Students = db.tbl_Students.Find(id);
            if (tbl_Students == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Students);
        }

        // POST: Students/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tbl_Students tbl_Students = db.tbl_Students.Find(id);
            db.tbl_Students.Remove(tbl_Students);
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

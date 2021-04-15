using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SampleEmployee.Model;

namespace SampleEmployee.Controllers
{
    public class employeesController : Controller
    {
        private employeedatadbEntities db = new employeedatadbEntities();

        // GET: tblemployees
        public ActionResult Index()
        {
            var tblemployees = db.tblemployees.Include(t => t.tbldepartment);
            return View(tblemployees.ToList());
        }

        // GET: tblemployees/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblemployee tblemployee = db.tblemployees.Find(id);
            if (tblemployee == null)
            {
                return HttpNotFound();
            }
            return View(tblemployee);
        }

        // GET: tblemployees/Create
        public ActionResult Create()
        {
            ViewBag.DeptId = new SelectList(db.tbldepartments, "Id", "Dname");
            return View();
        }

        // POST: tblemployees/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EmpId,Ename,DeptId")] tblemployee tblemployee)
        {
            if (ModelState.IsValid)
            {
                db.tblemployees.Add(tblemployee);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DeptId = new SelectList(db.tbldepartments, "Id", "Dname", tblemployee.DeptId);
            return View(tblemployee);
        }

        // GET: tblemployees/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblemployee tblemployee = db.tblemployees.Find(id);
            if (tblemployee == null)
            {
                return HttpNotFound();
            }
            ViewBag.DeptId = new SelectList(db.tbldepartments, "Id", "Dname", tblemployee.DeptId);
            return View(tblemployee);
        }

        // POST: tblemployees/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EmpId,Ename,DeptId")] tblemployee tblemployee)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblemployee).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DeptId = new SelectList(db.tbldepartments, "Id", "Dname", tblemployee.DeptId);
            return View(tblemployee);
        }

        // GET: tblemployees/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblemployee tblemployee = db.tblemployees.Find(id);
            if (tblemployee == null)
            {
                return HttpNotFound();
            }
            return View(tblemployee);
        }

        // POST: tblemployees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tblemployee tblemployee = db.tblemployees.Find(id);
            db.tblemployees.Remove(tblemployee);
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

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
    public class departmentsController : Controller
    {
        private employeedatadbEntities db = new employeedatadbEntities();

        // GET: tbldepartments
        public ActionResult Index()
        {
            return View(db.tbldepartments.ToList());
        }

        // GET: tbldepartments/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbldepartment tbldepartment = db.tbldepartments.Find(id);
            if (tbldepartment == null)
            {
                return HttpNotFound();
            }
            return View(tbldepartment);
        }

        // GET: tbldepartments/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tbldepartments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Dname,Location")] tbldepartment tbldepartment)
        {
            if (ModelState.IsValid)
            {
                db.tbldepartments.Add(tbldepartment);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tbldepartment);
        }

        // GET: tbldepartments/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbldepartment tbldepartment = db.tbldepartments.Find(id);
            if (tbldepartment == null)
            {
                return HttpNotFound();
            }
            return View(tbldepartment);
        }

        // POST: tbldepartments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Dname,Location")] tbldepartment tbldepartment)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbldepartment).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tbldepartment);
        }

        // GET: tbldepartments/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbldepartment tbldepartment = db.tbldepartments.Find(id);
            if (tbldepartment == null)
            {
                return HttpNotFound();
            }
            return View(tbldepartment);
        }

        // POST: tbldepartments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tbldepartment tbldepartment = db.tbldepartments.Find(id);
            db.tbldepartments.Remove(tbldepartment);
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

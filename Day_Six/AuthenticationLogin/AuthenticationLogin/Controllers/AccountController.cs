using AuthenticationLogin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AuthenticationLogin.Controllers
{
    public class AccountController : Controller
    {
        employeedbEntities db = new employeedbEntities();
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(tbllogin model)
        {
            if (ModelState.IsValid)
            {
                tbllogin data = db.tbllogins.Where(x => x.username.Equals(model.username) && x.password.Equals(model.password)).FirstOrDefault();
                if (data != null)
                {
                    return RedirectToAction("Dashboard");

                }
                else
                {
                    ViewBag.ErrorMessage = "Username and Password Mismatch";
                    return View(model);
                }
            }
            return View(model);
        }

        public ActionResult Dashboard()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(tbllogin model)
        {
            if (ModelState.IsValid)
            {
                if (db.tbllogins.Where(x => x.username.Equals(model.username) && x.password.Equals(model.password)).Any())
                {
                    ViewBag.ErrorMessage = "User already exists!";
                    return View();
                }
                else
                {
                    db.tbllogins.Add(model);
                    db.SaveChanges();
                    return RedirectToAction("Login");
                }
            }
            else
            {
                ViewBag.ErrorMessage = "All fields are required";
                return View(model);
            }
        }
    }
}
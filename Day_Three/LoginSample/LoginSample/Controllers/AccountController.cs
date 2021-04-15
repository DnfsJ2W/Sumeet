using LoginSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginSample.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginModel logdata)
        {
            if (logdata.UserName.Equals("sumeet") && logdata.Password.Equals("sum1234"))
                return RedirectToAction("Index");
            else
            {
                ViewBag.errorMessage = "Invalid username/password";
                return View(logdata);
            }
        }
    }
}
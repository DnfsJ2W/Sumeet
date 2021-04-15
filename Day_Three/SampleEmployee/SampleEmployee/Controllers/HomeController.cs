using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SampleEmployee.Model;

namespace SampleEmployee.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Login logdata)
        {
            if(logdata.UserName.Equals("sumeet") && logdata.Password.Equals("sum1234"))
            return RedirectToAction("Index");
            else
           {
                ViewBag.errorMessage = "Invalid username/password";
                return View(logdata); 
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
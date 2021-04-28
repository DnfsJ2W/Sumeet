using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AuthenticationIdentityFramework.Controllers
{  
    [Authorize]
    public class DemoController : Controller
    {
        // GET: Demo
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Page1()
        {
            return View();
        }
        [Authorize(Users = "sumit@gmail.com")]
        public ActionResult Page2()
        {
            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hanlerror_OutputCachefilter.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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
        [HandleError]
        public ActionResult Page1()
        {
            throw new Exception("Something went wrong!!");

           
        }
        [HandleError(View ="Errorpage")]
        public ActionResult Page2()
        {
            throw new Exception("Something went wrong!!");
        }
        [OutputCache(Duration =1000)]
        public ActionResult Page3()
        {
            return View();
        }
    }
}
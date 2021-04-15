using RSS_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RSS_REPO;

namespace RSS_UI.Controllers
{
    public class AccountController : Controller
    {
        private readonly ILoginRepo _data;

        public AccountController(ILoginRepo data)
        {
            this._data = data;
        }
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(tblLogin model)
        {
          tblLogin login =  _data.ValidateUser(model.UserName, model.Password);
            if (login == null)
            {
                ViewBag.ErrorMessage = "Invalid username and password";
                return View(model);
            }
            else
            {
                Session["username"] = model.UserName;
                return RedirectToAction("EmployeeHomePage");
            }
        }
        public ActionResult EmployeeHomePage()
        {

            return View();

        }

    }

}
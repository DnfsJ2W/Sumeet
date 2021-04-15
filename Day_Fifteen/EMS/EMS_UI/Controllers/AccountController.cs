using EMS_DAL.Models;
using EMS_REPO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMS_UI.Controllers
{
    public class AccountController : Controller
    {
        private readonly ILoginRepo _data;

        public AccountController(ILoginRepo data)
        {
            this._data = data;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(TblLogin model)
        {
            TblLogin login = _data.ValidateUser(model.UserName, model.Password);
            if (login == null)
            {
                ViewBag.ErrorMessage = "Invalid username and password";
                return View(model);
            }
            else
            {

                HttpContext.Session.SetString("username", model.UserName);
                return RedirectToAction("EmployeeHomePage");
            }

            
        }
        public IActionResult EmployeeHomePage()
        {
            return View();
        }
    }
}

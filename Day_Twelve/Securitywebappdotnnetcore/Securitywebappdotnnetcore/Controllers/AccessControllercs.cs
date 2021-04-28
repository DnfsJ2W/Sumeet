using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Securitywebappdotnnetcore.Controllers
{
    public class AccessControllercs : Controller
    {
        [Authorize(Roles ="Super Admin")]
        public IActionResult Index()
        {
            return View();
        }
        [Authorize(Roles ="Admin")]
         public IActionResult Page1()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Securitywebappdotnnetcore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Page1()
        {
            return View();
        }
    }
}

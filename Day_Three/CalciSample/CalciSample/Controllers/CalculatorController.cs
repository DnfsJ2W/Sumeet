using CalciSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CalciSample.Controllers
{
    public class CalculatorController : Controller
    {
        // GET: Calculator
        public ActionResult Calc()
        {

            return View();
                
        }
        [HttpPost]
        public ActionResult Calc(calcmodel data,string Add,string Sub,string Mult,string Div)
        {

            if (!string.IsNullOrEmpty(Add))
                data.Result = data.Num1 + data.Num2;
        
        if(!string.IsNullOrEmpty(Sub))
                data.Result = data.Num1 - data.Num2;
        
        if(!string.IsNullOrEmpty(Mult))
                data.Result = data.Num1 * data.Num2;
            if (!string.IsNullOrEmpty(Div))
                data.Result = data.Num1 / data.Num2;

            return View(data);

        }

    }
}

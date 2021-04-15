using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using razorcore.Models;

namespace razorcore.Pages
{
    public class DemoModel : PageModel
    {
        [BindProperty]
        public Calculator Calci { get; set; }
        public void OnGet()
        {

        }
            public IActionResult OnPostAdd()
            {
                Calci.Result = Calci.Num1 + Calci.Num2;
                return Page();
            }

            public IActionResult OnPostSub()
            {
                Calci.Result = Calci.Num1 - Calci.Num2;
                return Page();
            }


            public IActionResult OnPostMul()
            {
                Calci.Result = Calci.Num1 * Calci.Num2;
                return Page();
            }


            public IActionResult OnPostDiv()
            {
                Calci.Result = Calci.Num1 / Calci.Num2;
                return Page();
            }
        }
}

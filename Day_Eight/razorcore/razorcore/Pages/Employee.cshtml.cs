using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using razorcore.Models;

namespace razorcore.Pages
{
    public class EmployeeModel : PageModel
    {
        [BindProperty]
        public Login Logins { get; set; }
        [ViewData]
        public string ErrorMessage { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            if (Logins.UserName.Equals("sumeet") && Logins.Password.Equals("sum123"))
            {
              return  RedirectToPage("welcome");
            }
            else {
                ErrorMessage = "Invalid";
                return Page();
            }
        }
    }
}

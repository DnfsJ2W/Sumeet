using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace razorcore.Models
{
    public class Login
    {
        [Required]
        [Display(Name ="Enter UserName")]
        public string UserName { get; set; }
        [Required]
        [Display(Name = "Enter Password")]
        public string Password { get; set; }
    }
}

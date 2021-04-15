using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LoginSample.Models
{
    public class LoginModel
    {
      
        
            [Required]

            [Display(Name = "Enter UserName")]
            public string UserName { get; set; }
            [Required]
            [DataType(DataType.Password)]
            [Display(Name = "Enter Password")]
            public string Password { get; set; }
        }

}
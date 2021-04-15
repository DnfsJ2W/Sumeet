using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace AuthenticationLogin.Models
{
    public class LoginValidator
    {
        [DataType(DataType.Password)]
        [Required(ErrorMessage ="Password is required")]
        [Display(Name ="Password:")]
        public string password { get; set; }
        [Required(ErrorMessage = "Username is required")]
        [Display(Name = "Username:")]
        public string username { get; set; }
    }
    [MetadataType(typeof(LoginValidator))]
    public partial class tbllogin
    { 
    
    }
}
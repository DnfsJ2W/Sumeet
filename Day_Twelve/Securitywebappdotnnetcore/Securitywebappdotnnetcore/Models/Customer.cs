using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Securitywebappdotnnetcore.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string FisrstName { get; set; }

        public string LastName { get; set; }
    }
}

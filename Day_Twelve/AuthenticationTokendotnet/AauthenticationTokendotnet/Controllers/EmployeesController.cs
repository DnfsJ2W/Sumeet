using AauthenticationTokendotnet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AauthenticationTokendotnet.Controllers
{
    [Authorize]
    public class EmployeesController : ApiController
    {
        EmployeeDBauthtestEntities db = new EmployeeDBauthtestEntities();
        public IEnumerable<Employee> Get() 
        {
            return db.Employees.ToList();
        }
    }
}

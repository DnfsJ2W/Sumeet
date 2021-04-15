using EMS_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS_REPO
{
    public class Login : ILoginRepo
    {
        prodbContext db = new prodbContext();
        public TblLogin ValidateUser(string username, string password)
        {
            TblLogin login = db.TblLogins.FirstOrDefault(a => a.UserName == username && a.Password == password);
            return login;
        }
    }
}

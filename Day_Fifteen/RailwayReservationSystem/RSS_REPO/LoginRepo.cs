using RSS_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSS_REPO
{
   public class LoginRepo : ILoginRepo
    {
        prodbEntities db = new prodbEntities();
        public tblLogin ValidateUser(string username, string password)
        {
            tblLogin login = db.tblLogins.FirstOrDefault(a => a.UserName == username && a.Password == password);
            return login;
        }
    }
}

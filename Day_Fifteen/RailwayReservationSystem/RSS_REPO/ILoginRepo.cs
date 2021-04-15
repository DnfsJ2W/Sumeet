using RSS_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSS_REPO
{
    public interface ILoginRepo
    {
        tblLogin ValidateUser(string username, string password);


    }
}

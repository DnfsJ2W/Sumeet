using System;
using EMS_DAL;
using EMS_DAL.Models;

namespace EMS_REPO
{
    public interface ILoginRepo
    {
        TblLogin ValidateUser(string username, string password);


    }
}

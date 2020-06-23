using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Shopping.Kart.Models.DataClass;

namespace Shopping.Kart.Models
{
    interface IModelInterface
    {
        int Login(string username, string pass);
        string RegistrationNewuserProfile(tbl_UserDetail tbl_UserDetail);
        
    }
}

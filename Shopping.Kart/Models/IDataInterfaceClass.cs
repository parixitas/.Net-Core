using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Shopping.Kart.Models.DataClass;

namespace Shopping.Kart.Models
{
    public class IDataInterfaceClass : IModelInterface
    {
        private Database_DbContext _db=new Database_DbContext();

        public int Login(string username, string pass)
        {
            int i = 0;
            tbl_UserDetail tbl_UserDetail = new tbl_UserDetail();
            var _result = _db.UserDetails.Where(user => user.UserName == username && user.Password == pass).SingleOrDefault();
            if (_result == null)
            {
                i = -1;
            }
            else
                i = 1;
           // i = Convert.ToInt32(_result);
            return i;
        }

        //public IDataInterfaceClass(Database_DbContext _DbContext)
        //{
        //    _db = _DbContext;
        //}

        public string RegistrationNewuserProfile(tbl_UserDetail tbl_UserDetail)
        {
            tbl_UserDetail userRDetail = new tbl_UserDetail();
            userRDetail.UserName = tbl_UserDetail.UserName;
            userRDetail.email = tbl_UserDetail.email;
            userRDetail.Password = tbl_UserDetail.Password;
            _db.UserDetails.Add(userRDetail);
            _db.SaveChanges();
            return "successfull";
        }

    }
}

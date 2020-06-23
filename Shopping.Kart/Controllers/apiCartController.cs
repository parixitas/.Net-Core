using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static Shopping.Kart.Models.DataClass;
using Shopping.Kart.Models;

namespace Shopping.Kart.Controllers
{
  
    [Route("api/[controller]")]
    [ApiController]
    public class apiCartController : ControllerBase
    {
        private readonly IModelInterface modelInterface = new IDataInterfaceClass();
        [HttpPost]
        public int LoginUser(tbl_UserDetail tbl_UserDetail)
        {
            int _result = modelInterface.Login(tbl_UserDetail.UserName, tbl_UserDetail.Password);
            return _result;
        }

        [HttpPost]
        public string Registration(tbl_UserDetail tbl_UserDetail)
        {
            var _result = modelInterface.RegistrationNewuserProfile(tbl_UserDetail);
            return _result;
        }
    }
}
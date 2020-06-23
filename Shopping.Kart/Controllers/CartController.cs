using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shopping.Kart.Models;
using static Shopping.Kart.Models.DataClass;


namespace Shopping.Kart.Controllers
{
    public class CartController : Controller
    {
        apiCartController cartController = new apiCartController();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult MYCartProfile()
        {
            ViewBag.Message = "Welcome ShoppingCart";
            return View();
        }
        public IActionResult MyCartLogin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MyCartLogin(tbl_UserDetail tbl_UserDetail)
        {
            int _result = cartController.LoginUser(tbl_UserDetail);
            if (_result == 1)
            {
                 return RedirectToAction("MYCartProfile");
            }
            else
                return View();
        }

        public IActionResult MYCartRegistration()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MYCartRegistration(tbl_UserDetail tbl_UserDetail)
        {

            var _result = cartController.Registration(tbl_UserDetail);
            if (_result == "successfull")
            {
                return RedirectToAction("MYCartLogin");
            }
            else
                return View("Please Register after few min");
        }
    }
}
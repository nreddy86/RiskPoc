using ARUP.Context;
using ARUP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ARUP.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        DataContext db = new DataContext();
        public ActionResult LoginEmployee()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LoginEmployee(Users LoginVar)
        {
            var result1 = (from usr in db.Users where usr.Username == LoginVar.Username select usr.Password).FirstOrDefault();

            if (result1 == LoginVar.Password)
            {
                return RedirectToAction("User", "User", new { area = "Admin" });
            }
            else
            {
                ViewBag.Message = string.Format("UserName and Password is incorrect");
                return View();
            }
        }
    }
}
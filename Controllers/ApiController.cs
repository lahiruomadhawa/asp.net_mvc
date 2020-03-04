using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using shad_web_app.Models.Entity;
using shad_web_app.Models.Service;

namespace shad_web_app.Controllers
{
    public class ApiController : Controller
    {

        UserService us = new UserService();

        [HttpPost]
        public ActionResult reg(User user)
        {
            string message = us.createUser(user);
            ViewBag.adw = user.UserName;
            ViewBag.adw2 = message;
            return View("../Home/Register");
        }

        [HttpPost]
        public ActionResult auth(string uname, string upass)
        {
            if (uname.Equals("admin") && upass.Equals("123"))
            {
                ViewBag.users = us.getAllUsers();

                ViewBag.msg = uname;
                return View("../Home/Home");
            }
            else
            {
                string state = us.validate(uname, upass);

                if (state.Equals("ok"))
                {
                    ViewBag.msg = uname;
                    return View("../Home/Home");
                }
                else
                {
                    ViewBag.msg = state;
                    return View("../Home/login_view");
                }
                
            }
        }

        public ActionResult getAllUsers()
        {
            ViewBag.users = us.getAllUsers();
            return View("../Home/Home");
        }

        public ActionResult deleteUser(string name)
        {
            string state = us.deleteUser(name);
            ViewBag.users = us.getAllUsers();
            return View();
        }
    }
}
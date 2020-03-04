using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace shad_web_app.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult login_view()
        {

            return View();
        }

        public ActionResult reg_view()
        {
            ViewBag.adw = null;
            return View("Register");
        }

        public ActionResult resetpw()
        {
            return View("ResetPassword");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
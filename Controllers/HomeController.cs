using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_ActionResult.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ViewResult Register()
        {
            return View();
        }

        public ViewResult Login()
        {
            return View();
        }

        public ViewResult ResetPassword()
        {
            return View("ResetPwd");
        }

        public ViewResult ForgotPassword()
        {
            return View("ForgotPwd");
        }

        public ViewResult Kumar()
        {
            return View("~/Views/Vikash/Kumar.cshtml");
        }
    }
}
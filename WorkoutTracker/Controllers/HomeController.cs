using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WorkoutTracker.Models;

namespace WorkoutTracker.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult Login()
        {
            return PartialView("Login", new LoginViewModel());
        }

        public PartialViewResult Register()
        {
            return PartialView("Register", new RegisterViewModel());
        }

    }
}
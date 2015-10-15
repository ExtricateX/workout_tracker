using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WorkoutTracker.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Dashboard
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }

        [Authorize]
        public ActionResult Workouts()
        {
            return View();
        }

        [Authorize]
        public ActionResult Schedule()
        {
            return View();
        }

        [Authorize]
        public ActionResult ProgressReport()
        {
            return View();
        }

        [Authorize]
        public ActionResult Exercises()
        {
            return View();
        }
    }
}
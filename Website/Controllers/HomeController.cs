using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Website.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Illustration()
        {
            return View();
        }

        public ActionResult Design()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
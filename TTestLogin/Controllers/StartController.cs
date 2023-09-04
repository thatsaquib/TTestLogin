using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TTestLogin.Controllers
{
    public class StartController : Controller
    {
        // GET: Start
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login(string username, string password)
        {
            ViewBag.User = username;
            return View();
        }
    }
}
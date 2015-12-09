using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace dyPic.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult LogIn()
        {
            return View();
        }
    }
}
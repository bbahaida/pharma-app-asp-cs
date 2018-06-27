using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PharmaWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (Session["user"] == null)
                return RedirectToAction("Index", "Login");
            return View();
        }

    }
}
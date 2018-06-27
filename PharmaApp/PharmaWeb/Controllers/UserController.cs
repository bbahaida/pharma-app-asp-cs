using PharmaDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PharmaWeb.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            if (Session["user"] == null)
                return RedirectToAction("Index","Login");
            return View(InstanceResolver.Instance.User.GetAll());
        }

        public ActionResult Add()
        {
            ViewBag.permission = false;
            if (Session["user"] == null)
                return RedirectToAction("Index", "Login");
            if (!((User)Session["user"]).Login.Equals("admin"))
            {
                ViewBag.error = true;
                ViewBag.permission = true;
                return View();
            }
            ViewBag.error = false;
            return View();
        }
        [HttpPost]
        public ActionResult Add(FormCollection collection)
        {
            if (Session["user"] == null)
                return RedirectToAction("Index", "Login");
            ViewBag.permission = false;
            string name = Request["name"];
            string login = Request["login"];
            string password = Request["password"];
            string confirm = Request["confirm"];

            ViewBag.error = false;

            if (name.Equals("") || login.Equals("") || password.Equals("") || confirm.Equals("") || !password.Equals(confirm))
            {
                ViewBag.error = true;
                return View();
            }
            User f = InstanceResolver.Instance.User.AddUser(
                new User
                {
                    Name = name,
                    Login = login,
                    Password = password
                }, (User)Session["user"]);
            if (f != null)
            {
                return RedirectToAction("Index", "User");
            }
            ViewBag.error = true;
            return View();
        }
    }
}
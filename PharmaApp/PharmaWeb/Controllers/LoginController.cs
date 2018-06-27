using PharmaDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PharmaWeb.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            if (Session["user"] != null)
                return RedirectToAction("Index","Home");
            return View();
        }
        [HttpPost]
        public ActionResult Index(FormCollection collection)
        {

            string login = Request["login"];
            string pw = Request["password"];
            try
            {
                User u = InstanceResolver.Instance.User.GetUserByAuth(login,pw);
                if(u != null)
                {
                    Session.Add("user",u);
                    return RedirectToAction("Index", "Home");
                }
                else
                    return View();
            }
            catch
            {
                return View();
            }
        }
    }
}
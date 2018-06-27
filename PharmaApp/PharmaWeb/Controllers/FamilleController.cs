using PharmaDomain;
using PharmaDomain.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PharmaWeb.Controllers
{
    public class FamilleController : Controller
    {

        // GET: Famille
        public ActionResult Index()
        {
            if (Session["user"] == null)
                return RedirectToAction("Index", "Login");
            return View(InstanceResolver.Instance.Famille.GetAll());
        }
        public ActionResult Add()
        {
            ViewBag.error = false;
            if (Session["user"] == null)
                return RedirectToAction("Index", "Login");
            return View();
        }
        [HttpPost]
        public ActionResult Add(FormCollection collection)
        {
            if (Session["user"] == null)
                return RedirectToAction("Index", "Login");

            string designation = Request["designation"];
            ViewBag.error = false;
            
            if(designation.Equals(""))
                return View();
            Famille f = InstanceResolver.Instance.Famille.AddFamille(
                new Famille
                {
                    Designation = designation
                },(User)Session["user"]);
            if (f != null)
            {
                return RedirectToAction("Index","Famille");
            }
            ViewBag.error = true;
            return View();
        }
        public ActionResult Edit(int id)
        {
            ViewBag.error = false;
            if (Session["user"] == null)
                return RedirectToAction("Index", "Login");
            Famille f = InstanceResolver.Instance.Famille.GetOneFamilleById(id);
            if(f == null)
                return RedirectToAction("Index", "Famille");
            
            return View(f);
        }
        [HttpPost]
        public ActionResult Edit(FormCollection collection)
        {
            if (Session["user"] == null)
                return RedirectToAction("Index", "Login");

            int code = int.Parse(Request["code"]);
            Famille f = InstanceResolver.Instance.Famille.GetOneFamilleById(code);
            string designation = Request["designation"];
            ViewBag.error = false;
            if (designation.Equals(""))
                return View(f);
            f.Designation = designation;
            f = InstanceResolver.Instance.Famille.EditFamille(f, (User)Session["user"]);
            if (f != null)
            {
                return RedirectToAction("Index", "Famille");
            }
            ViewBag.error = true;
            return View();
        }
        public ActionResult Delete(int id)
        {
            if (Session["user"] == null)
                return RedirectToAction("Index", "Login");
            if(id > 0)
                InstanceResolver.Instance.Famille.DeleteFamille(InstanceResolver.Instance.Famille.GetOneFamilleById(id), (User)Session["user"]);

            return RedirectToAction("Index", "Famille");
        }
        
    }
}
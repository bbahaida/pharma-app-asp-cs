using PharmaDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PharmaWeb.Controllers
{
    public class MedicamentController : Controller
    {
        // GET: Medicament
        public ActionResult Index()
        {
            if (Session["user"] == null)
                return RedirectToAction("Index", "Login");
            return View(InstanceResolver.Instance.Medicament.GetAll());
        }
        public ActionResult Add()
        {
            ViewBag.error = false;
            if (Session["user"] == null)
                return RedirectToAction("Index", "Login");
            ViewBag.famille = InstanceResolver.Instance.Famille.GetAll().ToList();
            ViewBag.stock = InstanceResolver.Instance.Stock.GetAll().ToList();
            return View();
        }
        [HttpPost]
        public ActionResult Add(FormCollection collection)
        {
            if (Session["user"] == null)
                return RedirectToAction("Index", "Login");

            ViewBag.famille = InstanceResolver.Instance.Famille.GetAll().ToList();
            ViewBag.stock = InstanceResolver.Instance.Stock.GetAll().ToList();
            string libelle = Request["libelle"];
            decimal prix = decimal.Parse(Request["prix"]);
            int famille = int.Parse(Request["famille"]);
            int quantite = int.Parse(Request["quantite"]);
            int stock = int.Parse(Request["stock"]);
            ViewBag.error = false;
            
            if (libelle.Equals("") || prix <= 0 || famille <= 0 || quantite <= 0 || stock <= 0)
            {

                ViewBag.message = "L'un des champs n'est pas valide";
                ViewBag.error = true;
                return View();
            }
            
            Medicament m = InstanceResolver.Instance.Medicament.AddMedicament(new Medicament {
                LibelleMedicament = libelle,
                CodeFamille =famille,
                Prix =prix
            }, (User)Session["user"]);
            if (m!=null)
            {
                StockMedi sm = InstanceResolver.Instance.StockMedi.AddStockMedi(
                    new StockMedi
                    {
                        NumStock = stock,
                        CodeMedicament = m.CodeMedicament,
                        QuantiteMedicament = quantite
                    }
                    , (User)Session["user"]);
                return RedirectToAction("Index", "Medicament");
            }
            ViewBag.error = true;
            ViewBag.message = "L'un des objets est null";
            return View();
        }
    }
}
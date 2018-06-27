using PharmaDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PharmaWeb.Controllers
{
    public class VenteController : Controller
    {
        // GET: Vente
        public ActionResult Index()
        {
            if (Session["user"] == null)
                return RedirectToAction("Index", "Login");
            return View(InstanceResolver.Instance.VenteMedi.GetAll());
        }
        public ActionResult Add()
        {
            if (Session["user"] == null)
                return RedirectToAction("Index", "Login");
            ViewBag.error = false;
            return View();
        }
        [HttpPost]
        public ActionResult Add(FormCollection collection)
        {
            ViewBag.error = false;
            if (Session["user"] == null)
                return RedirectToAction("Index", "Login");

            Medicament m = InstanceResolver.Instance.Medicament.GetOneMedicamentById(int.Parse(Request["medicament"]));
            Stock s = InstanceResolver.Instance.Stock.GetOneStockById(int.Parse(Request["stock"]));
            int quantity = int.Parse(Request["quantite"]);
            decimal montant = quantity * m.Prix;
            
            if (m == null || s == null )
            {
                ViewBag.message = "Stock ou Medicament null";
                ViewBag.error = true;
                return View();
            }
            if (InstanceResolver.Instance.StockMedi.GetOneStockMediById(s.NumStock,m.CodeMedicament) == null )
            {
                ViewBag.message = "Pas de medicament dans ce stock";
                ViewBag.error = true;
                return View();
            }
            if (InstanceResolver.Instance.StockMedi.GetOneStockMediById(s.NumStock,m.CodeMedicament).QuantiteMedicament < quantity)
            {
                ViewBag.message = "Quantite n'est pas valide";
                ViewBag.error = true;
                return View();
            }
            Vente v = InstanceResolver.Instance.Vente.AddVente(
                new Vente
                {
                    MontantVente = montant,
                    DateVente = DateTime.Now
                }, (User)Session["user"]);
            if (v != null)
            {
                VenteMedi vm = InstanceResolver.Instance.VenteMedi.AddVenteMedi(
                    new VenteMedi
                    {
                        NumVente = v.NumVente,
                        CodeMedicament = m.CodeMedicament,
                        QuantiteMedicament = quantity
                    },s,(User)Session["user"]);
                if(vm != null)
                    return RedirectToAction("Index", "Vente");
            }
            ViewBag.error = true;
            ViewBag.message = "L'un des objets est null";
            return View();
        }
    }
}
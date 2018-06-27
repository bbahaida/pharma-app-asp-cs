using PharmaDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PharmaWeb.Controllers
{
    public class StockController : Controller
    {
        // GET: Stock
        public ActionResult Index()
        {
            if (Session["user"] == null)
                return RedirectToAction("Index", "Login");

            return View(InstanceResolver.Instance.Stock.GetAll());
        }

        public ActionResult Add(int id)
        {
            if(id == 1)
            {
                Stock s = InstanceResolver.Instance.Stock.AddStock(
                    new Stock { QuantiteMedicament = 0},
                    (User)Session["user"]
                    );
                return RedirectToAction("Index","Stock");
            }
            return RedirectToAction("Index", "Stock");
        }
    }
}
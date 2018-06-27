using PharmaDomain.Dao;
using PharmaDomain.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PharmaWeb.Controllers
{
    public class MedicamentsController : Controller
    {
        IMedicamentService MedicamentService = new MedicamentServiceImpl(new MedicamentDaoImpl(),new VenteMediDaoImpl(), new StockMediDaoImpl());
        // GET: Medicaments
        public ActionResult Index()
        {
            
            return View(MedicamentService.GetAll());
        }

        // GET: Medicaments/Details/5
        public ActionResult Details(int id)
        {
            
            return View(MedicamentService.GetOneMedicamentById(id));
        }

        // GET: Medicaments/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Medicaments/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Medicaments/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Medicaments/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Medicaments/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Medicaments/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

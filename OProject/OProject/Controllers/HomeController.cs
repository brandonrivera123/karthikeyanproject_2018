using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OProject.Models;

namespace OProject.Controllers
{
    public class HomeController : Controller
    {
        private ODBContext db = new ODBContext();
        public ActionResult Index()
        {
            var opportunities = from o in db.Opportunities
                                orderby o.OID
                                select o;
            return View(opportunities);
        }

        

        // GET: Opportunity/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Opportunity/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Opportunity/Create
        [HttpPost]
        public ActionResult Create(Opportunity o)
        {
            try
            {
                db.Opportunities.Add(o);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Opportunity/Edit/5
        public ActionResult Edit(int id)
        {
            
            var opportunity = db.Opportunities.Single(m => m.OID == id);
            return View(opportunity);
        }

        // POST: Opportunity/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                var opportunity = db.Opportunities.Single(m => m.OID == id);
                if (TryUpdateModel(opportunity)) {
                    db.SaveChanges();
                return RedirectToAction("Index");
                }
                return View(opportunity);
            }
            catch
            {
                return View();
            }
        }

        // GET: Opportunity/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Opportunity/Delete/5
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
        
       




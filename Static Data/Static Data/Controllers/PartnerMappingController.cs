using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Static_Data.Models;

namespace Static_Data.Controllers
{
    public class PartnerMappingController : Controller
    {
        private Static_DataContext db = new Static_DataContext();

        // GET: PartnerMapping
        public ActionResult Index()
        {
            return View(db.PartnerMappings.ToList());
        }

        // GET: PartnerMapping/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PartnerMapping partnerMapping = db.PartnerMappings.Find(id);
            if (partnerMapping == null)
            {
                return HttpNotFound();
            }
            return View(partnerMapping);
        }

        // GET: PartnerMapping/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PartnerMapping/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,TE,PartnerName")] PartnerMapping partnerMapping)
        {
            if (ModelState.IsValid)
            {
                db.PartnerMappings.Add(partnerMapping);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(partnerMapping);
        }

        // GET: PartnerMapping/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PartnerMapping partnerMapping = db.PartnerMappings.Find(id);
            if (partnerMapping == null)
            {
                return HttpNotFound();
            }
            return View(partnerMapping);
        }

        // POST: PartnerMapping/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,TE,PartnerName")] PartnerMapping partnerMapping)
        {
            if (ModelState.IsValid)
            {
                db.Entry(partnerMapping).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(partnerMapping);
        }

        // GET: PartnerMapping/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PartnerMapping partnerMapping = db.PartnerMappings.Find(id);
            if (partnerMapping == null)
            {
                return HttpNotFound();
            }
            return View(partnerMapping);
        }

        // POST: PartnerMapping/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PartnerMapping partnerMapping = db.PartnerMappings.Find(id);
            db.PartnerMappings.Remove(partnerMapping);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

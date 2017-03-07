using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Backoffice.DAL;
using Backoffice.Models;

namespace Backoffice.Controllers
{
    public class ListingRegionController : Controller
    {
        private DALContext db = new DALContext();

        // GET: ListingRegion
        public ActionResult Index()
        {
            var listingRegions = db.ListingRegions.Include(l => l.ParentRegion);
            return View(listingRegions.ToList());
        }

        // GET: ListingRegion/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ListingRegion listingRegion = db.ListingRegions.Find(id);
            if (listingRegion == null)
            {
                return HttpNotFound();
            }
            return View(listingRegion);
        }

        // GET: ListingRegion/Create
        public ActionResult Create()
        {
            ViewBag.ParentRegionID = new SelectList(db.ListingRegions, "ID", "Name");
            return View();
        }

        // POST: ListingRegion/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,ParentRegionID")] ListingRegion listingRegion)
        {
            if (ModelState.IsValid)
            {
                db.ListingRegions.Add(listingRegion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ParentRegionID = new SelectList(db.ListingRegions, "ID", "Name", listingRegion.ParentRegionID);
            return View(listingRegion);
        }

        // GET: ListingRegion/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ListingRegion listingRegion = db.ListingRegions.Find(id);
            if (listingRegion == null)
            {
                return HttpNotFound();
            }
            ViewBag.ParentRegionID = new SelectList(db.ListingRegions, "ID", "Name", listingRegion.ParentRegionID);
            return View(listingRegion);
        }

        // POST: ListingRegion/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,ParentRegionID")] ListingRegion listingRegion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(listingRegion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ParentRegionID = new SelectList(db.ListingRegions, "ID", "Name", listingRegion.ParentRegionID);
            return View(listingRegion);
        }

        // GET: ListingRegion/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ListingRegion listingRegion = db.ListingRegions.Find(id);
            if (listingRegion == null)
            {
                return HttpNotFound();
            }
            return View(listingRegion);
        }

        // POST: ListingRegion/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ListingRegion listingRegion = db.ListingRegions.Find(id);
            db.ListingRegions.Remove(listingRegion);
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

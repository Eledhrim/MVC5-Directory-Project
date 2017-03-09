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
    public class VenueController : Controller
    {
        private DALContext db = new DALContext();

        // GET: Venue
        public ActionResult Index()
        {
            var venues = db.Venues.Include(v => v.Category).Include(v => v.ListingRegion);
            return View(venues.ToList());
        }

        // GET: Venue/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Venue venue = db.Venues.Find(id);
            if (venue == null)
            {
                return HttpNotFound();
            }
            return View(venue);
        }

        // GET: Venue/Create
        public ActionResult Create()
        {
            ViewBag.CategoryID = new SelectList(db.Categories, "ID", "Name");
            ViewBag.ListingRegionID = new SelectList(db.ListingRegions, "ID", "Name");
            return View();
        }

        // POST: Venue/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Title,Description,Address,Phone1,Phone2,Website,Lat,Long,VideoUrl,FacebookUrl,TwitterUrl,YoutubeUrl,PinterestUrl,SubmittedBy,ConfirmedBy,SubmitDate,ConfirmDate,CategoryID,ListingRegionID")] Venue venue)
        {
            if (ModelState.IsValid)
            {
                db.Venues.Add(venue);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CategoryID = new SelectList(db.Categories, "ID", "Name", venue.CategoryID);
            ViewBag.ListingRegionID = new SelectList(db.ListingRegions, "ID", "Name", venue.ListingRegionID);
            return View(venue);
        }

        // GET: Venue/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Venue venue = db.Venues.Find(id);
            if (venue == null)
            {
                return HttpNotFound();
            }
            ViewBag.CategoryID = new SelectList(db.Categories, "ID", "Name", venue.CategoryID);
            ViewBag.ListingRegionID = new SelectList(db.ListingRegions, "ID", "Name", venue.ListingRegionID);
            return View(venue);
        }

        // POST: Venue/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Title,Description,Address,Phone1,Phone2,Website,Lat,Long,VideoUrl,FacebookUrl,TwitterUrl,YoutubeUrl,PinterestUrl,SubmittedBy,ConfirmedBy,SubmitDate,ConfirmDate,CategoryID,ListingRegionID")] Venue venue)
        {
            if (ModelState.IsValid)
            {
                db.Entry(venue).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CategoryID = new SelectList(db.Categories, "ID", "Name", venue.CategoryID);
            ViewBag.ListingRegionID = new SelectList(db.ListingRegions, "ID", "Name", venue.ListingRegionID);
            return View(venue);
        }

        // GET: Venue/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Venue venue = db.Venues.Find(id);
            if (venue == null)
            {
                return HttpNotFound();
            }
            return View(venue);
        }

        // POST: Venue/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Venue venue = db.Venues.Find(id);
            db.Venues.Remove(venue);
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

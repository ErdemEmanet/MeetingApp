using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MeetingApp.Models;

namespace MeetingApp.Controllers
{
    public class MeetingDetailsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: MeetingDetails
        public ActionResult Index()
        {
            return View(db.MeetingDetails.ToList());
        }

        // GET: MeetingDetails/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MeetingDetail meetingDetail = db.MeetingDetails.Find(id);
            if (meetingDetail == null)
            {
                return HttpNotFound();
            }
            return View(meetingDetail);
        }

        // GET: MeetingDetails/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MeetingDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Meeting_ID,Meeting_Title,Meeting_Date,Meeting_StartTime,Meeting_EndTime")] MeetingDetail meetingDetail)
        {
            if (ModelState.IsValid)
            {
                db.MeetingDetails.Add(meetingDetail);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(meetingDetail);
        }

        // GET: MeetingDetails/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MeetingDetail meetingDetail = db.MeetingDetails.Find(id);
            if (meetingDetail == null)
            {
                return HttpNotFound();
            }
            return View(meetingDetail);
        }

        // POST: MeetingDetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Meeting_ID,Meeting_Title,Meeting_Date,Meeting_StartTime,Meeting_EndTime")] MeetingDetail meetingDetail)
        {
            if (ModelState.IsValid)
            {
                db.Entry(meetingDetail).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(meetingDetail);
        }

        // GET: MeetingDetails/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MeetingDetail meetingDetail = db.MeetingDetails.Find(id);
            if (meetingDetail == null)
            {
                return HttpNotFound();
            }
            return View(meetingDetail);
        }

        // POST: MeetingDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MeetingDetail meetingDetail = db.MeetingDetails.Find(id);
            db.MeetingDetails.Remove(meetingDetail);
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

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DropDownDemo.Models;

namespace DropDownDemo.Controllers
{
    public class StreamingServicesController : Controller
    {
        private StreamingDB db = new StreamingDB();

        // GET: StreamingServices
        public ActionResult Index()
        {
            return View(db.StreamingServices.ToList());
        }

        // GET: StreamingServices/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StreamingService streamingService = db.StreamingServices.Find(id);
            if (streamingService == null)
            {
                return HttpNotFound();
            }
            return View(streamingService);
        }

        // GET: StreamingServices/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StreamingServices/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "StreamingServiceID,ServiceName")] StreamingService streamingService)
        {
            if (ModelState.IsValid)
            {
                db.StreamingServices.Add(streamingService);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(streamingService);
        }

        // GET: StreamingServices/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StreamingService streamingService = db.StreamingServices.Find(id);
            if (streamingService == null)
            {
                return HttpNotFound();
            }
            return View(streamingService);
        }

        // POST: StreamingServices/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "StreamingServiceID,ServiceName")] StreamingService streamingService)
        {
            if (ModelState.IsValid)
            {
                db.Entry(streamingService).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(streamingService);
        }

        // GET: StreamingServices/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StreamingService streamingService = db.StreamingServices.Find(id);
            if (streamingService == null)
            {
                return HttpNotFound();
            }
            return View(streamingService);
        }

        // POST: StreamingServices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            StreamingService streamingService = db.StreamingServices.Find(id);
            db.StreamingServices.Remove(streamingService);
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

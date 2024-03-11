using AlbumsWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using System.Net;
using System.Web.UI.WebControls;
using System.Data.Entity.Core.Metadata.Edm;
using System.Runtime.Remoting.Messaging;

namespace AlbumsWebApp.Controllers
{
    public class AlbumsController : Controller
    {
        private AlbumsDB db = new AlbumsDB();
        
        // GET: Albums [HttpGet] no nescessary, because it's default
        public ActionResult Index()
        {
            ViewBag.blabla = "Greetings!";
            //var allAlbums = db.Albums.ToList()
            //return View("Index", allAlbums);
            return View(db.Albums.ToList());
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
                //return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Album album = db.Albums.Find(id);
            
            if (album == null)
            {
                return HttpNotFound(); //short for below
                //return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            return View(album);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Album newAlbum)
        {
            if (ModelState.IsValid)
            {
                db.Albums.Add(newAlbum);
                db.SaveChanges();
                return RedirectToAction("Index"); // Redirects to Index in AlbumsControllers
            }
            return View();
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Album album = db.Albums.Find(id);
            if (album == null)
            {
                return HttpNotFound();
            }
            return View(album);
        }

        [HttpPost]
        public ActionResult Edit(Album editedAlbum)
        {
            if (ModelState.IsValid)
            {
                db.Entry(editedAlbum).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            Album album = db.Albums.Find(id);
            if (album == null)
            {
                return HttpNotFound();
            }
            return View(album);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult ConfirmDelete(int? id)
        {
            Album unluckyAlbum = db.Albums.Find(id);
            db.Albums.Remove(unluckyAlbum);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
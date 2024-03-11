using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Globalization;
using PhotoSharingApplication.Models;
using System.EnterpriseServices;
using System.Drawing;
using System.IO;
using System.Diagnostics;
using System.Web.UI.WebControls;
using static System.Net.Mime.MediaTypeNames;

namespace PhotoSharingApplication.Controllers
{
    [ValueReporter] public class PhotoController : Controller
    {
        private PhotoSharingContext context = new PhotoSharingContext();

        // GET: Photo
        public ActionResult Index() { return View(context.Photos.ToList()); }

        public ActionResult Display(int? id)
        {
            if (id == null) { return HttpNotFound(); }
            Photo photo = context.Photos.Find(id);
            if (photo == null) { return HttpNotFound(); }
            return View(photo);
        }

        [HttpGet] public ActionResult Create()
        {
            Photo newPhoto = new Photo() { CreatedDate = DateTime.Today };
            return View(newPhoto);
        }

        [HttpPost] public ActionResult Create(Photo photo, HttpPostedFileBase image)
        {
            if(!ModelState.IsValid || image == null) { return View("Create", photo); }
            photo.ImageMimeType = image.ContentType;
            photo.PhotoFile = new byte[image.ContentLength];
            image.InputStream.Read(photo.PhotoFile, 0, image.ContentLength);
            context.Photos.Add(photo);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int? id)
        {
            if (id == null) { return HttpNotFound(); };
            Photo photo = context.Photos.Find(id);
            if (photo == null) { return HttpNotFound(); };
            return View(photo);
        }

        [HttpPost, ActionName("Delete")] public ActionResult DeleteAct(int id)
        {
            Photo deletedPhoto = context.Photos.Find(id);
            context.Photos.Remove(deletedPhoto);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int? id)
        {
            if (id == null) { return HttpNotFound(); };
            Photo editedPhoto = context.Photos.Find(id);
            if (editedPhoto == null) { return HttpNotFound(); };
            return View(editedPhoto);
        }

        [HttpPost] public ActionResult Edit(Photo editedPhoto, HttpPostedFileBase image)
        {
            if(!ModelState.IsValid) { return View(editedPhoto); }
            Photo changedPhoto = context.Photos.Find(editedPhoto.PhotoID);
            if (image != null)
            {
                changedPhoto.ImageMimeType = image.ContentType;
                changedPhoto.PhotoFile = new byte[image.ContentLength];
                image.InputStream.Read(changedPhoto.PhotoFile, 0, image.ContentLength);
            }
            changedPhoto.Title = editedPhoto.Title;
            changedPhoto.Description = editedPhoto.Description;
            changedPhoto.CreatedDate = editedPhoto.CreatedDate;
            changedPhoto.UserName = editedPhoto.UserName;

            context.Entry(changedPhoto).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult GetImage(int? id)
        {
            if (id == null) { return HttpNotFound(); }
            Photo photo = context.Photos.Find(id);
            if (photo == null) { return null; }
            return File(photo.PhotoFile, photo.ImageMimeType);
        }
    }
}
using AlbumsWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AlbumsWebApp.Controllers
{
    public class HomeController : Controller
    {
        private AlbumsDB db = new AlbumsDB();
        //public ActionResult Index()
        //{
        //    return View();
        //}

        //public ActionResult Index()
        //{
        //    return RedirectToAction("Index", "Albums");
        //}

        //retunrs string instead of a view
        //public ActionResult Index()
        //{
        //    return Content("<h2>Greetings, traveler! Stay a while and listen...</h2>");
        //}

        //public ActionResult Index()
        //{
        //    return File("web.config", "xml"); //you wouldn't do this though
        //}

        //returns db as Json
        //public ActionResult Index()
        //{
        //    return Json(db.Albums.ToList(), JsonRequestBehavior.AllowGet);
        //}

        //public ActionResult Index()
        //{
        //    return Redirect("https://lingscars.com");
        //}
        public ActionResult Index()
        {
            return RedirectToAction("Index", "Albums");
        }

        public ActionResult Blabla()
        {
            return Content("Hallooooooo");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
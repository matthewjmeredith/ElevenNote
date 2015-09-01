using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ElevenNote.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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
        public ActionResult Matt()
        {
            ViewBag.Message = "Matt's Page.";
            return View();
        }
        public ActionResult Meredith()
        {
            ViewBag.Message = "Meredith's Page.";
            return View();
        }
        public ActionResult Notes()
        {
            ViewBag.Message = "Notes";
            return View();
        }
    }
}
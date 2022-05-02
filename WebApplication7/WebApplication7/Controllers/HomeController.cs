using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication7.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["Message1"] = "view data";
            ViewBag.Message2 = "view bag";
            TempData["Message3"] = "India";
            string[] Rivers = { "Ganga","jamna","kaveri","Godavari"};

            TempData["river"] = Rivers;
            return View();
        }

        public ActionResult About()
        {  
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}
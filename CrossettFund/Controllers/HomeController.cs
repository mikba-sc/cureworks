using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace crosset.Controllers
{
    public class HomeController : Controller
    {
        [Route("", Order = 1)]
        [Route("default.asp", Order = 2)]
        public ActionResult Index()
        {
            ViewBag.pageType = "home";
            return View();
        }

        [Route("projects.asp")]
        public ActionResult Projects()
        {
            ViewBag.pageType = "projects";
            return View();
        }

        [Route("highlight.asp")]
        public ActionResult Highlights()
        {
            ViewBag.pageType = "highlight";
            return View();
        }

        [Route("guidelines.asp")]
        public ActionResult Guidelines()
        {
            ViewBag.pageType = "guidelines";
            return View();
        }

        [Route("application.asp")]
        public ActionResult Application()
        {
            ViewBag.pageType = "application";
            return View();
        }

        [Route("contact.asp")]
        public ActionResult Contact()
        {
            ViewBag.pageType = "contact";
            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VRPD_WebApp.Controllers
{
    public class HomeController : Controller
    {
        [Route("Home/About")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [Route("Home/Contact")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [Route("")]
        [Route("Home")]
        [Route("Home/Index")]
        public ActionResult Index()
        {
            return View();
        }
    }
}

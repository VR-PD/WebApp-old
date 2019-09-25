using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VRPD_WebApp.Controllers
{
    public class ErrorController : Controller
    {
        public ActionResult Index()
        {
            if (Request.QueryString.HasKeys())
                return RedirectToAction("Index");
            return View();
        }
    }
}

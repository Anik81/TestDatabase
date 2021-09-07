using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TechReview3.Controllers
{
    public class LaunchPageController : Controller
    {
        // GET: LaunchPage
        public ActionResult Index()
        {
            return View("Index", "_Layout");
        }

        
    }
}
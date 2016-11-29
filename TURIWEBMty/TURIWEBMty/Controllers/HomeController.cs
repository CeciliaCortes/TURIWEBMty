using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TURIWEBMty.Models;

namespace TURIWEBMty.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            logio obj = new logio();
            return View(obj);
        }
    }
}

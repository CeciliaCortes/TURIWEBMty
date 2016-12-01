using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TURIWEBMty.Controllers
{
    public class ApodacaController : Controller
    {
        // GET: Apodaca
        public ActionResult Index()
        {
            return PartialView();
        }
    }
}
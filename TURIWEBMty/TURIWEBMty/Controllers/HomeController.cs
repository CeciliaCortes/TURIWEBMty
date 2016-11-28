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
        [HttpPost]
        public ActionResult Index(logio objuserlogin)
        {
            var display = Userloginvalues().Where(m => m.Correo == objuserlogin.Correo && m.Contraseña == objuserlogin.Contraseña).FirstOrDefault();
            if (display != null)
            {
                ViewBag.Status = "Bienvenido";
            }
            else
            {
                ViewBag.Status = "Contraseña o Usuario Incorrecto";
            }
            return View(objuserlogin);
        }
        public List<logio> Userloginvalues()
        {
            List<logio> objModel = new List<logio>();
            objModel.Add(new logio { Correo = "user1", Contraseña = "Password1" });
            objModel.Add(new logio { Correo = "user2", Contraseña = "Password2" });
            objModel.Add(new logio { Correo = "user3", Contraseña = "Password3" });
            objModel.Add(new logio { Correo = "user4", Contraseña = "Password4" });
            objModel.Add(new logio { Correo = "user5", Contraseña = "Password5" });
            return objModel;
        }
    }
}

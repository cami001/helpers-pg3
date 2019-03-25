using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Helpers.Models;

namespace Helpers.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Fom()
        {
           

            return View();
        }

        [HttpPost]
        public ActionResult Fom(req form)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("Datos", form);
            }
            else
            {
                return View("Fom");
            }

            
        }

        public ActionResult Datos(req form)
        {
         

            return View(form);
        }
    }
}
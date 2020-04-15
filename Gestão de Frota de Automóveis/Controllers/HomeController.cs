using Gestão_de_Frota_de_Automóveis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gestão_de_Frota_de_Automóveis.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult GridUtilizador()
        {
            Gestão_de_Frota_de_AutomoveisEntities db = new Gestão_de_Frota_de_AutomoveisEntities();
            var result = db.Utilizador.ToList();
            return View(result);
        }
        
    }
}
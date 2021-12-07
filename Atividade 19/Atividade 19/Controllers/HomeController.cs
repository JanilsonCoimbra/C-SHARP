using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Atividade_19.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        { 
            var Lista = Models.Veiculos.GetCarros();
            ViewBag.lista = Lista;
            return View();
        }

        public ActionResult Cadastrar()
        {
            ViewBag.Message = "Your application description page.";
            var Lista = Models.Veiculos.GetCarros();
            ViewBag.lista = Lista;
            return View();
        }

        
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
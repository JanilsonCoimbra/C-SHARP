using Atividade_19.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Atividade_19.Controllers
{
    public class CadastrarController : Controller
    {

        // GET: Cadastrar
        public ActionResult Veiculos()
        {
            return View();
        }

        [HttpGet]
        public void Salvar()
        {
            var veiculo = new Veiculos();
            veiculo.Nome = Request["Nome"];
            veiculo.Modelo = Request["Modelo"];
            veiculo.Cor = Request["Cor"];

            Console.WriteLine("Dados pegos com sucesso");
            Console.WriteLine(veiculo.Nome);


            Response.Redirect("/Cadastrar");
        }
    }

}
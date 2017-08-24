using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Fiap.Exemplo02.MVC.Models;

namespace Fiap.Exemplo02.MVC.Controllers
{
    public class VagaController : Controller
    {
        private static List<Vaga> _banco = new List<Vaga>();

        // GET: Vaga
        [HttpGet]
        public ActionResult Cadastrar()
        {  
            CarregarLista();
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Vaga vaga)
        {
            _banco.Add(vaga);
            ViewBag.msg = "Sucesso ao cadastrar!";
            CarregarLista();
            return View();
        }

        private void CarregarLista()
        {
            List<string> niveis = new List<string>();
            niveis.Add("Junior");
            niveis.Add("Pleno");
            niveis.Add("Sênior");

            ViewBag.opcoes = new SelectList(niveis);
        }

        public ActionResult Listar()
        {
            return View(_banco);
        }
    }
}
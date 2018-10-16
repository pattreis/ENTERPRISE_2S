using Fiap.NAC.Correcao.Models;
using Fiap.NAC.Correcao.Unit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.NAC.Correcao.Controllers
{
    public class BebidaController : Controller
    {

        private UnitOfWork _unit = new UnitOfWork();

        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Bebida bebida)
        {
            _unit.BebidaRepository.Cadastrar(bebida);
            _unit.Salvar();
            TempData["msg"] = "Bebida Cadastrada com sucesso!";

            return RedirectToAction("Cadastrar");
        }

        [HttpGet]
        public ActionResult Listar()
        {            
            return View(_unit.BebidaRepository.Listar());
        }

        [HttpGet]
        public ActionResult Pesquisar(string nome) {

            var lista = _unit.BebidaRepository.BuscarPor(b => b.Nome.Contains(nome));

            return View("Listar", lista);
        }


        [HttpPost]
        public ActionResult Remover(int codigo) {
            _unit.BebidaRepository.Remover(codigo);
            _unit.Salvar();
            return View("Listar");
        }


        




    }
}
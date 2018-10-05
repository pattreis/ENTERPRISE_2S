using Fiap08.Web.MVC.Models;
using Fiap08.Web.MVC.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap08.Web.MVC.Controllers
{
    public class DependenteController : Controller
    {
        private UnitOfWork _unit = new UnitOfWork();

        [HttpGet]
        public ActionResult Cadastrar()
        {
            var lista = _unit.ResponsavelRepository.Listar();
            ViewBag.responsaveis = new SelectList(lista, "ResponsavelId", "Nome");
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Dependente dependente)
        {
            _unit.DependenteRepository.Cadastrar(dependente);
            _unit.Salvar();
            TempData["msg"] = "Dependente cadastrado!";
            return RedirectToAction("cadastrar");
        }

        [HttpGet]
        public ActionResult Listar() {         

            var dependentes = _unit.DependenteRepository.Listar();
            return View(dependentes);
        }

    }
}
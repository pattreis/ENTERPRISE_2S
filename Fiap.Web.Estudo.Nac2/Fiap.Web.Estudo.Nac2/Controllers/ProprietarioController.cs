using Fiap.Web.Estudo.Nac2.Models;
using Fiap.Web.Estudo.Nac2.Unit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Web.Estudo.Nac2.Controllers
{
    public class ProprietarioController : Controller
    {

        private UnitOfWork _unit = new UnitOfWork();

        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Proprietario pro)
        {
            _unit.ProprietarioRepository.Cadastrar(pro);
            _unit.Salvar();
            return View();
        }
    }
}
using Fiap07.Web.MVC.Models;
using Fiap07.Web.MVC.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap07.Web.MVC.Controllers
{
    public class JogadorController : Controller
    {
        private BrasfootContext _context = new BrasfootContext();

        [HttpGet]
        public ActionResult BuscarPorTime(int codigo) {

            var result = _context.Jogadores.Include("Time").Where(r => r.TimeId == codigo || codigo == null).ToList();

            var times = _context.Times.ToList();
            ViewBag.times = new SelectList(times, "TimeId", "Nome");

            return RedirectToAction("Listar", result);
        }

        [HttpGet]
        public ActionResult Listar()
        {
            var lista = _context.Jogadores.Include("Time").ToList();

            var times = _context.Times.ToList();
            ViewBag.times = new SelectList(times, "TimeId", "Nome");

            return View(lista);
        }

        [HttpPost]
        public ActionResult Cadastrar(Jogador jogador)
        {
            _context.Jogadores.Add(jogador);
            _context.SaveChanges();
            TempData["msg"] = "Jogador cadastrado!";
            return RedirectToAction("Cadastrar");
        }

        [HttpGet]
        public ActionResult Cadastrar()
        {
            //Buscar os times cadastrados no banco 
            var lista = _context.Times.ToList();
            //Enviar através da ViewBag os times
            ViewBag.churros = new SelectList(lista, "TimeId", "Nome");
            return View();
        }


    }
}
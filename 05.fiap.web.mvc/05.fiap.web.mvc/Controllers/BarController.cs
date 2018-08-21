using _05.fiap.web.mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _05.fiap.web.mvc.Controllers
{
    public class BarController : Controller
    {

        private static List<Bar> _banco = new List<Bar>();

        [HttpGet]
        public ActionResult Listar()
        {
            return View(_banco);
        }

        // GET: Bar
        [HttpGet]
        public ActionResult Cadastrar()
        {
            List<string> listaCidades = new List<string>();
            listaCidades.Add("São Paulo");
            listaCidades.Add("Rio de Janeiro");

            ViewBag.listaCidades = new SelectList(listaCidades);
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Bar bar)
        {
            _banco.Add(bar);
            TempData["msg"] = "Cadastrado com sucesso!";

            return RedirectToAction("Cadastrar");
        }
    }
}
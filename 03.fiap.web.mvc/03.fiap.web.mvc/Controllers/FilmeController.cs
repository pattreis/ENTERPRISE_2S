using _03.fiap.web.mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _03.fiap.web.mvc.Controllers
{
    public class FilmeController : Controller
    {

        // Post: Filme
        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Filme filme)
        {
            //Passar valores para a view (pagina html)           
            ViewBag.titulo = filme.Nome;
            //Passar uma mensagem para a view
            TempData["msg"] = "Filme Cadastrado!";

            //Passar um objeto para a view
            return View(filme);
            //Retornar um texo para o browser
            //return Content(filme.Nome);            
        }

        
    }
}
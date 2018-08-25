using Fiap._06.web.mvc.Models;
using Fiap._06.web.mvc.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap._06.web.mvc.Controllers
{
    public class AnimalController : Controller
    {
        private PetshopContext _context = new PetshopContext();

        [HttpGet]
        // GET: Animal
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Animal animal) {

            _context.Entry(animal);

            TempData["msg"] = "Animal cadastrado com sucesso!";
            return View();
        }
    }
}
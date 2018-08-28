using Fiap._06.web.mvc.Models;
using Fiap._06.web.mvc.Persistencia;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap._06.web.mvc.Controllers
{
    public class AnimalController : Controller
    {
        private PetshopContext _context = new PetshopContext();

        public ActionResult Alterar(Animal animal) {

            _context.Entry(animal).State = EntityState.Modified;
            _context.SaveChanges();
            TempData["msg"] = "Animal Atualizado!";

            return RedirectToAction("Listar");
        }

        [HttpGet]
        public ActionResult Alterar(int id) {

            var animal = _context.Animais.Find(id);

            //retorna a pagina com os dados do animal
            return View(animal);               

        }


        [HttpGet]
        // GET: Animal
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Animal animal) {

            _context.Animais.Add(animal);
            _context.SaveChanges();

            TempData["msg"] = "Animal cadastrado com sucesso!";
            return RedirectToAction("Cadastrar");
        }

        [HttpGet]
        public ActionResult Listar() {
            return View(_context.Animais.ToList());
        }

    }
}
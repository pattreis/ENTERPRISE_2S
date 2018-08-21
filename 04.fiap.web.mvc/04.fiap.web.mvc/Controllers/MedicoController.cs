﻿using _04.fiap.web.mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _04.fiap.web.mvc.Controllers
{
    public class MedicoController : Controller
    {
        //Simular um banco de dados
        private static List<Medico> _banco = new List<Medico>();

        [HttpGet]
        public ActionResult Listar() {

            //Envia a lista de médicos para a tela
            return View(_banco);
        }


        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Medico medico)
        { 
            _banco.Add(medico);//add no banco de dados
            TempData["msg"] = "Médico cadastrado!"; // Mensagem para a tela
            
            // Faz redirect para não cadastrar vários no F5
            return RedirectToAction("Cadastrar");
        }

    }
}
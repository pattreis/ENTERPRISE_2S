using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PS_ESTUDO.Controllers
{
    public class JogoController : Controller
    {
        // GET: Jogo
        public ActionResult Cadastrar()
        {
            return View();
        }
    }
}
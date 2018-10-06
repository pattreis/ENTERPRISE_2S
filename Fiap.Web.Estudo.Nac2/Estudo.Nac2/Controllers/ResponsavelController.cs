using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Estudo.Nac2.Controllers
{
    public class ResponsavelController : Controller
    {
        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }
    }
}
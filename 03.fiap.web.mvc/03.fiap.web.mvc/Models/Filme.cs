using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _03.fiap.web.mvc.Models
{
    public class Filme
    {
        public string Nome { get; set; }

        public DateTime DtLancamento { get; set; }

        public string Genero { get; set; }

        public bool Legendado { get; set; }
    }
}
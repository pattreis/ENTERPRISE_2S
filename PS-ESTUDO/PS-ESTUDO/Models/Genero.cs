using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PS_ESTUDO.Models
{
    public class Genero
    {
        public int Codigo { get; set; }

        public string Nome { get; set; }

        public List<Jogo> jogo { get; set; }

    }
}
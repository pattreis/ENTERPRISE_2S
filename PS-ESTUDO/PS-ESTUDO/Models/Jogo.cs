using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PS_ESTUDO.Models
{
    public class Jogo
    {
        public int Codigo { get; set; }

        public string Nome { get; set; }

        public DateTime DataLancamento { get; set; }

        public Plataforma plataforma { get; set; }

        public bool Disponivel { get; set; }

        public int GeneroId { get; set; }
        public Genero Genero { get; set; }
    }
}
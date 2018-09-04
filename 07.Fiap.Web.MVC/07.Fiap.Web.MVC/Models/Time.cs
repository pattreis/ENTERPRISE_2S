using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _07.Fiap.Web.MVC.Models
{
    public class Time
    {
        public int TimeId { get; set; }
        public string Nome { get; set; }
        public bool Mundial { get; set; }

        //RELACIONAMENTO 1 PRA 1
        public Tecnico Tecnico { get; set; }
        //RELACIONAMENTO 1 PRA 1
        public int TecnicoId { get; set; }

        //RELACIONAMENTO 1 PRA MUITOS
        public IList<Jogador> Jogadores { get; set; }


        // RELACIONAMENTO MUITOS PARA MUITOS
        public IList<Campeonato> Campeonatos { get; set; }
    }
}
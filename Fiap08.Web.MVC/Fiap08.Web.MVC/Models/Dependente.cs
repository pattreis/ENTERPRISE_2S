﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Fiap08.Web.MVC.Models
{
    public class Dependente
    {
        public int DependenteId { get; set; }

        public string Nome { get; set; }

        [UIHint("Date")]
        [Display(Name ="Data Nascimento")]
        public DateTime DataNascimento { get; set; }

        //Relacionamento
        public Responsavel Responsavel { get; set; }

        public int ResponsavelId { get; set; }

        public bool Bolsista { get; set; }

    }
}
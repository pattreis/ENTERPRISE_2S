using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Fiap.NAC.Correcao.Models
{
    public class Bebida
    {

        public int BebidaId { get; set; }

        public string Nome { get; set; }        

        [DisplayName("Data de Validade")]
        [UIHint("Date")]
        public DateTime DataValidade { get; set; }

        public decimal Valor { get; set; }

        public bool Alcoolismo { get; set; }
    }
}
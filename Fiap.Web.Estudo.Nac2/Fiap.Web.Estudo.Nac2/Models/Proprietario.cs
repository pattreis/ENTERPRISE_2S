using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Fiap.Web.Estudo.Nac2.Models
{
    public class Proprietario
    {
        public int ProprietarioId { get; set; }

        public string Nome { get; set; }

        public int Telefone { get; set; }

        [UIHint("Date")]
        [Display(Name ="Data de Nascimento")]
        public DateTime DtNasc { get; set; }

        List<Imovel> Imovels { get; set; }

        List<Veiculo> Veiculos { get; set; }

    }
}
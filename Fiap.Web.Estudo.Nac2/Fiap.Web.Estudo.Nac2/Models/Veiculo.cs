using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap.Web.Estudo.Nac2.Models
{
    public class Veiculo
    {
        public int VeiculoId { get; set; }

        public string Montadora { get; set; }

        public string Modelo { get; set; }

        public bool Blindado { get; set; }
    }
}
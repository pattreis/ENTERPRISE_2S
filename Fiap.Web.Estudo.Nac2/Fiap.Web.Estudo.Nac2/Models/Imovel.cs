using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap.Web.Estudo.Nac2.Models
{
    public class Imovel
    {
        public int ImovelId { get; set; }

        public string Descricao  { get; set; }

        public TipoImovel Tipo { get; set; }
    }
}
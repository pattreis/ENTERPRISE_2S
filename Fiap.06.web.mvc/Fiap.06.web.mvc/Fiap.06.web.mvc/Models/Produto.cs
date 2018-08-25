using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Fiap._06.web.mvc.Models
{
    [Table("TProduto")]
    public class Produto
    {
        public int ProdutoId { get; set; }

        [Required]
        public string Nome { get; set; }
    }
}
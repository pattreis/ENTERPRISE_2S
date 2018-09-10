using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace _06.Fiap.Web.MVC.Models
{
    [Table("TProduto")]
    public class Produto
    {
        [Column("Id")]
        public int ProdutoId { get; set; }

        [Required]
        [MaxLength(200)]
        public string Nome { get; set; }
    }
}
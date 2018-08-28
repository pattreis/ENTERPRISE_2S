using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Fiap._06.web.mvc.Models
{
    [Table("TAnimal")]
    public class Animal
    {
        [Column("ID")]
        public int AnimalId { get; set; }

        [Required]
        [StringLength(255,MinimumLength = 3)]
        public string Nome { get; set; }

        public string Raca { get; set; }

        public bool Castrado { get; set; }

        public double Peso { get; set; }

    }
}
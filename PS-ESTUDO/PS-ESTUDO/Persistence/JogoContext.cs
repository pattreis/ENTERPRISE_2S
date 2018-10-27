using PS_ESTUDO.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PS_ESTUDO.Persistence
{
    public class JogoContext : DbContext
    {
        public DbSet<Genero> Generos { get; set; }

        public DbSet<Jogo> Jogos { get; set; }

    }

}
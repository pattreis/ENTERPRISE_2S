using Fiap.Web.Estudo.Nac2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Fiap.Web.Estudo.Nac2.Persistence
{
    public class ProprietarioContext : DbContext
    {
        public DbSet<Proprietario> Proprietarios { get; set; }

        public DbSet<Veiculo> Veiculos { get; set; }

        public DbSet<Imovel> Imovels { get; set; }
    }
}
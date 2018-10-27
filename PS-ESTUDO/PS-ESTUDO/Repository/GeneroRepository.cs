using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PS_ESTUDO.Models;
using PS_ESTUDO.Persistence;

namespace PS_ESTUDO.Repository
{
    public class GeneroRepository : IGeneroRepository
    {
        private JogoContext _context;

        public GeneroRepository(JogoContext context)
        {
            _context = context;
        }

        public void cadastrar(Genero genero)
        {
            _context.Generos.Add(genero);
        }

        public IList<Genero> Listar()
        {
            return _context.Generos.ToList();
        }
    }
}
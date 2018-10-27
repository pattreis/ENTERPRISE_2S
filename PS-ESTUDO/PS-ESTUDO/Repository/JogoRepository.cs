using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using PS_ESTUDO.Models;
using PS_ESTUDO.Persistence;

namespace PS_ESTUDO.Repository
{
    public class JogoRepository : IJogoRepository
    {


        private JogoContext _context;

        public JogoRepository(JogoContext context)
        {
            _context = context;
        }

        public void Atualizar(Jogo jogo)
        {
            _context.Entry(jogo).State = EntityState.Modified;
        }

        public Jogo Buscar(int Codigo)
        {
            return _context.Jogos.Find(Codigo);
        }

        public IList<Jogo> BuscarPor(Expression<Func<Jogo, bool>> filtros)
        {
            return _context.Jogos.Where(filtros).ToList();
        }

        public void Cadastrar(Jogo jogo)
        {
            _context.Jogos.Add(jogo);
        }

        public IList<Jogo> Listar()
        {
            return _context.Jogos.ToList();
        }

        public void Remover(int Codigo)
        {
            _context.Jogos.Remove(_context.Jogos.Find(Codigo));
        }
    }
}
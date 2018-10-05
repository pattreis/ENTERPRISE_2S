using Fiap08.Web.MVC.Models;
using Fiap08.Web.MVC.Persistencia;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace Fiap08.Web.MVC.Repositories
{
    public class DependenteRepository : IDependenteRepository
    {
        private EscolaContext _context;

        public DependenteRepository(EscolaContext context)
        {
            _context = context;
        }

        public void Alterar(Dependente dependente)
        {
            _context.Entry(dependente).State = EntityState.Modified;
        }

        public Dependente Buscar(int Codigo)
        {
            return _context.Dependentes.Find(Codigo);
        }

        public IList<Dependente> BuscarPor(Expression<Func<Dependente, bool>> filtros)
        {
            return _context.Dependentes.Include("Responsavel").Where(filtros).ToList();
        }

        public void Cadastrar(Dependente dependente)
        {
            _context.Dependentes.Add(dependente);
        }

        public IList<Dependente> Listar()
        {
            return _context.Dependentes.Include("Responsavel").ToList();
        }

        public void Remover(int Codigo)
        {
            var remov = Buscar(Codigo);
            _context.Dependentes.Remove(remov);
        }
    }
}
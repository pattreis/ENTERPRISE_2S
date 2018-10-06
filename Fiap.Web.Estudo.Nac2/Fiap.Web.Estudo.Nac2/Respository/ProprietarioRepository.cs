using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Fiap.Web.Estudo.Nac2.Models;
using Fiap.Web.Estudo.Nac2.Persistence;

namespace Fiap.Web.Estudo.Nac2.Respository
{
    public class ProprietarioRepository : IProprietarioRepository
    {

        private ProprietarioContext _context;
        private EntityState EntitState;

        public ProprietarioRepository(ProprietarioContext context)
        {
            _context = context;
        }

        public void Alterar(Proprietario proprietario)
        {
            _context.Entry(proprietario).State = EntityState.Modified;
        }

        public Proprietario Buscar(int proprietarioId)
        {
            return _context.Proprietarios.Find(proprietarioId);
        }

        public void Cadastrar(Proprietario proprietario)
        {
            _context.Proprietarios.Add(proprietario);
        }

        public void Remover(int Codigo)
        {
            Proprietario pro = Buscar(Codigo);
            _context.Proprietarios.Remove(pro);
        }

        public IList<Proprietario> Listar()
        {
            return _context.Proprietarios.ToList();
        }

        public IList<Proprietario> BuscarPor(Expression<Func<Proprietario, bool>> filtro)
        {
            return _context.Proprietarios.Where(filtro).ToList();
        }

        
    }
}
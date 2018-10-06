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
    public class ImovelRepository : IImovelRepository
    {
        private ProprietarioContext _context;

        public ImovelRepository(ProprietarioContext context)
        {
            _context = context;
        }

        public void Alterar(Imovel Imovel)
        {
            _context.Entry(Imovel).State = EntityState.Modified;
        }

        public Imovel Buscar(int ImovelId)
        {
            return _context.Imovels.Find(ImovelId);
        }

        public IList<Imovel> BuscarPor(Expression<Func<Imovel, bool>> filtro)
        {
            return _context.Imovels.Include("Proprietario").Where(filtro).ToList();
        }

        public void Cadastrar(Imovel imovel)
        {
            _context.Imovels.Add(imovel);
        }

        public IList<Imovel> Listar()
        {
            return _context.Imovels.Include("Proprietario").ToList();
        }

        public void Remover(int Codigo)
        {
            Imovel imovel = Buscar(Codigo);
            _context.Imovels.Remove(imovel);
        }
    }
}
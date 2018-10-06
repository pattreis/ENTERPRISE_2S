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
    public class VeiculoRepository : IVeiculoRepository
    {
        private ProprietarioContext _context;

        public VeiculoRepository(ProprietarioContext context)
        {
            _context = context;
        }

        public void Alterar(Veiculo Veiculo)
        {
            _context.Entry(Veiculo).State = EntityState.Modified;
        }

        public Veiculo Buscar(int VeiculoId)
        {
            return _context.Veiculos.Find(VeiculoId);
        }

        public IList<Veiculo> BuscarPor(Expression<Func<Veiculo, bool>> filtro)
        {
            return _context.Veiculos.Include("Proprietario").Where(filtro).ToList();
        }

        public void Cadastrar(Veiculo veiculo)
        {
            _context.Veiculos.Add(veiculo);
        }

        public IList<Veiculo> Listar()
        {
            return _context.Veiculos.Include("Proprietario").ToList();
        }

        public void Remover(int Codigo)
        {
            Veiculo vei = Buscar(Codigo);
            _context.Veiculos.Remove(vei);
        }
    }
}
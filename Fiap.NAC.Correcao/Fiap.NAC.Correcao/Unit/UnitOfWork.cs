using Fiap.NAC.Correcao.Persistence;
using Fiap.NAC.Correcao.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap.NAC.Correcao.Unit
{
    public class UnitOfWork : IDisposable
    {
        private BarContext _context = new BarContext();

        private BebidaRepository _bebidaRepository;

        public BebidaRepository BebidaRepository
        {
            get
            {
                if (_bebidaRepository == null)
                {
                    _bebidaRepository = new BebidaRepository(_context);
                }
                return _bebidaRepository;
            }

        }


        public void Salvar()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
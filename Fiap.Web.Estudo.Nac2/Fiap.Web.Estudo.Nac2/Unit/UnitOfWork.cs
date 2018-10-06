using Fiap.Web.Estudo.Nac2.Persistence;
using Fiap.Web.Estudo.Nac2.Respository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap.Web.Estudo.Nac2.Unit
{
    public class UnitOfWork : IDisposable
    {

        private ProprietarioContext _context = new ProprietarioContext();

        private IProprietarioRepository _proprietarioRepository;

        private IImovelRepository _imovelRepository;

        private IVeiculoRepository _veiculoRepository;

        public IProprietarioRepository ProprietarioRepository {
            get
            {
                if (_proprietarioRepository == null)
                {
                    _proprietarioRepository = new ProprietarioRepository(_context);
                }
                return _proprietarioRepository;
            }
        }

        public IImovelRepository ImovelRepository {
            get
            {
                if (_imovelRepository == null) {
                    _imovelRepository = new ImovelRepository(_context);
                }
                return _imovelRepository;
            }            
        }

        public IVeiculoRepository VeiculoRepository {
            get
            {
                if (_veiculoRepository == null)
                {
                    _veiculoRepository = new VeiculoRepository(_context);
                }
                return _veiculoRepository;
            }
        }

        public void Salvar() {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            if (_context == null)
            {
                _context.Dispose();
            }
            GC.SuppressFinalize(this);
        }
    }
}
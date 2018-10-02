﻿using Fiap08.Web.MVC.Persistencia;
using Fiap08.Web.MVC.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap08.Web.MVC.Units
{
    public class UnitOfWork : IDisposable
    {
        public EscolaContext _context = new EscolaContext();

        private IResponsavelRepository _responsavelRepository;

        private IDependenteRepository _dependenteRepository;

        public IResponsavelRepository ResponsavelRepository
        {
            get
            {
                if(_responsavelRepository == null)
                {
                    _responsavelRepository = new ResponsavelRepository(_context);
                }
                return _responsavelRepository;
            }
        }

        public IDependenteRepository DependenteRepository
        {
            get
            {
                if (_dependenteRepository == null)
                {
                    _dependenteRepository = new DependenteRepository(_context);
                }
                return _dependenteRepository;
            }
        }

        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
            }
            GC.SuppressFinalize(this);
        }

        public void Salvar()
        {
            _context.SaveChanges();
        }
    }
}
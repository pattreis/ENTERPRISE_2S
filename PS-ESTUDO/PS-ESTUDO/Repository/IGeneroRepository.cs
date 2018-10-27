using PS_ESTUDO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS_ESTUDO.Repository
{
    public interface IGeneroRepository
    {
        void cadastrar(Genero genero);

        IList<Genero> Listar();
    }
}

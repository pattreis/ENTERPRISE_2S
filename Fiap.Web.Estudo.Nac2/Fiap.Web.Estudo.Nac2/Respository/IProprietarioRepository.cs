using Fiap.Web.Estudo.Nac2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Web.Estudo.Nac2.Respository
{
    public interface IProprietarioRepository
    {
        void Cadastrar(Proprietario proprietario);

        void Alterar(Proprietario proprietario);

        void Remover(int Codigo);

        Proprietario Buscar(int proprietarioId);

        IList<Proprietario> Listar();

        IList<Proprietario> BuscarPor(Expression<Func<Proprietario, bool>> filtro);
    }
}

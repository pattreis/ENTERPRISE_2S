using Fiap.Web.Estudo.Nac2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Web.Estudo.Nac2.Respository
{
    public interface IImovelRepository
    {
        void Cadastrar(Imovel imovel);

        void Alterar(Imovel Imovel);

        void Remover(int Codigo);

        Imovel Buscar(int ImovelId);

        IList<Imovel> Listar();

        IList<Imovel> BuscarPor(Expression<Func<Imovel, bool>> filtro);
    }
}

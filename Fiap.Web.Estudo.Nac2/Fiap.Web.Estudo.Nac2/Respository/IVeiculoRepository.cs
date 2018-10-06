using Fiap.Web.Estudo.Nac2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Web.Estudo.Nac2.Respository
{
    public interface IVeiculoRepository
    {
        void Cadastrar(Veiculo veiculo);

        void Alterar(Veiculo Veiculo);

        void Remover(int Codigo);

        Veiculo Buscar(int VeiculoId);

        IList<Veiculo> Listar();

        IList<Veiculo> BuscarPor(Expression<Func<Veiculo, bool>> filtro);
    }
}

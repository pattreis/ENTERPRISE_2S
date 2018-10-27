using PS_ESTUDO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PS_ESTUDO.Repository
{
    interface IJogoRepository
    {
        void Cadastrar(Jogo jogo);

        Jogo Buscar(int Codigo);

        void Atualizar(Jogo jogo);

        void Remover(int Codigo);

        IList<Jogo> BuscarPor(Expression<Func<Jogo, bool>> filtros);

        IList<Jogo> Listar();
    }
}

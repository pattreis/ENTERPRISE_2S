using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Exercicios.br.com.fiap.Model
{
    class ContaCorrente : Conta
    {

        private TipoConta tipo { get; set; }


        public override void Depositar(decimal valor)
        {
            try
            {
                Saldo += valor;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public override void Retirar(decimal valor)
        {
            try
            {
                if (tipo.Equals("Comum") && Saldo < 0)
                {
                    throw new Exception("Saldo negativo! Não foi possível sacar...");
                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}

using _01.Exercicios.br.com.fiap.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciar objeto de conta corrente e poupança

            var cc1 = new ContaCorrente()
            {
                Agencia = 1,
                Numero = 2,
                tipo = TipoConta.Comum,
                Saldo = 1000,
                DataAbertura = DateTime.Now
            };
            

            var cp = new ContaPoupanca(0.06m);


            Boolean exit = true;

            do
            {
                Console.WriteLine("************************************");
                Console.WriteLine("Bem vindo!");
                Console.WriteLine("O que deseja fazer?");

                Console.WriteLine("1 - Retirar");
                Console.WriteLine("2 - Depositar");
                Console.WriteLine("3 - Consultar");
                Console.WriteLine("0 - Sair");
                Console.ReadKey();
                var ler = Console.ReadLine();



            } while (exit);





        }
    }
}


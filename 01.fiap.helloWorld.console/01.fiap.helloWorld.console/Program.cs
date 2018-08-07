using _01.fiap.helloWorld.console.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.fiap.helloWorld.console
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro(2010,2.0);
            carro.Ano = 2010;
            carro.ArCondicionado = false;

            System.Console.WriteLine(carro.Ano);
            System.Console.WriteLine(carro.ArCondicionado);
            Console.ReadKey();

            var lancha = new Lancha(2019,50)
            {
                BoteSalvaVida = true,
                Ano = 2010
            };
        }
    }
}

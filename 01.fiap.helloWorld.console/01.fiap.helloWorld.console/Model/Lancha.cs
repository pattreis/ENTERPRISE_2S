using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.fiap.helloWorld.console.Model
{
    class Lancha : Veiculo
    {
        public bool BoteSalvaVida { get; set; }

        public Lancha(int ano, double potencia) : base(ano, potencia)
        {

        }

        public override void Acelerar()
        {
            System.Console.WriteLine("Empurrando o Manete...");
        }

        public override void Desligar()
        {
            System.Console.WriteLine("Desligando a lancha...");
        }
    }
}

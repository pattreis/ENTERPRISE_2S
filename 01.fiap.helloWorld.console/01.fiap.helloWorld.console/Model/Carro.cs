using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.fiap.helloWorld.console.Model
{
    class Carro : Veiculo
    {
        public int Portas { get; set; }
        public bool ArCondicionado { get; set; }

        public TipoCarro Tipo;

        //Construtor
        public Carro(int ano, double potencia) : base (ano, potencia)
        {

        }

        //Sobrescrevendo o método da classe pai : Veiculo
        public override void Desligar()
        {
            System.Console.WriteLine("Virar a chave...");
        }
    }
}

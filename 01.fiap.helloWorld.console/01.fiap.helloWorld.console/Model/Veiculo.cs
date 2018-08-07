using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.fiap.helloWorld.console.Model
{
    abstract class Veiculo
    {
        private double _potencia;
        public double Potencia { get; set; }        

        public int Ano { get; set; }

        //Construtor
        public Veiculo(int ano, double potencia)
        {
            Ano = ano;
            Potencia = potencia;
        }

        //Métodos
        //Virtual autoriza a sobrescrita do método.
        public virtual void Acelerar() {
            System.Console.WriteLine("Veiculo Acelerando");
        }

        // Métodos abstratos não são implementados (códigos) , devem ser sobrescritos nas classes filhas
        public abstract void Desligar();

    }


   
}

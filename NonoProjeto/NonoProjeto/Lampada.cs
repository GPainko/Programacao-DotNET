using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonoProjeto
{
    internal class Lampada
    {
        public bool ligada;
        public double potencia;
        public string cor;

        public Lampada(double p, string c)
        {
            potencia = p;
            cor = c;
        }

        public void ligar()
        {
            if (ligada != true)
            {
                ligada = true;
                Console.WriteLine("Ligando...");
            }
            else {
                Console.WriteLine("Lampada já está Ligada");
            }
            
        }
        public void desligar()
        {
            if (ligada != false)
            {
                ligada = false;
                Console.WriteLine("Desligando...");
            }
            else
            {
                Console.WriteLine("Lampada já está desligada");
            }
        }

        public bool estaLigado()
        {
            return ligada;
        }
    }
}

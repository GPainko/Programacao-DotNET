using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decimoProjeto
{
    abstract class Animal
    {
        public String nome;

        public abstract void emitirSom();// método abstratos

        public void movimentar() // método concreto

        {
            Console.WriteLine("Animal está andando...");
        }
    }
}

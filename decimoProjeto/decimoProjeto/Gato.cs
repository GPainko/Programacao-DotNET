using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decimoProjeto
{
    internal class Gato : Animal
    {
        public String cor;

        public override void emitirSom()
        {
            Console.WriteLine("Miau Miua Mal");
        }

        public void roronar()
        {
            Console.WriteLine("Rorororo");
        }
    }
}

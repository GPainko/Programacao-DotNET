using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decimoProjeto
{
    internal class Peixe : Animal
    {
        public override void emitirSom()
        {
            Console.WriteLine("Glub glub");
        }

        public virtual void movimentar()
        {
            Console.WriteLine("está movimentando...");
        }
    }
}

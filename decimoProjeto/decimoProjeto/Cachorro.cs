using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace decimoProjeto
{
    internal class Cachorro : Animal
    {
        public String raça;
        public override void emitirSom()
        {
            Console.WriteLine("AU AU AU");
            
        }
        
    }
}

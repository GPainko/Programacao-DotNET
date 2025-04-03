using System.Security.Cryptography.X509Certificates;

namespace NonoProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lampada l = new Lampada(120,"roxo");

            Console.WriteLine("Potencia:" + l.potencia);
            Console.WriteLine("cor:" + l.cor);

            l.ligar();
            l.ligar();
            l.ligar();
            l.desligar();
            l.desligar();
            l.desligar();
            l.ligar();

            bool retorno = l.estaLigado();
            Console.WriteLine(retorno);
        }
    }
}

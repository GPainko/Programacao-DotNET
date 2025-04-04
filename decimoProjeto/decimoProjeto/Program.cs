namespace decimoProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testando Classe Abstrata");
            //Animal animal = new Animal();
            Cachorro cachorro = new Cachorro();
            cachorro.nome = "Roger";
            cachorro.raça = "Vira-Lata";
            Console.WriteLine("Chacorro:" +cachorro.nome);
            Console.WriteLine("Chacorro:" + cachorro.raça);
            cachorro.emitirSom();
            cachorro.movimentar();

            Console.WriteLine("-------------------------");
            Gato gato = new Gato(); 
            gato.nome = "mimosa";
            gato.cor = "preta";
            Console.WriteLine("gato:" + gato.nome);
            Console.WriteLine("gato:" + gato.cor);
            gato.emitirSom();
            gato.roronar();
            gato.movimentar();

            Console.WriteLine("-------------------------");
            Peixe peixe = new Peixe();
            peixe.nome = "Dorry";
            peixe.emitirSom();
            peixe.movimentar();
        }
    }
}

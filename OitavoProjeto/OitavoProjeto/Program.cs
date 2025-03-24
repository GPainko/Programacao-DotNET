namespace OitavoProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Pessoa p = new Pessoa(); // instanciando um objeto
            //Console.WriteLine("Digite o nome da pessoa: ");
            //p.nome = Console.ReadLine();
            //Console.WriteLine("Digite o email da emai: ");
            //p.email = Console.ReadLine();
            //Console.WriteLine("Digite o idade da idade: ");
            //p.idade = int.Parse(Console.ReadLine());

            //Console.WriteLine("Nome: " + p.nome + "\nemail: " + p.email + "\nidade: " + p.idade + "\n");

            //Carro c = new Carro(); // instanciando um objeto
            //Console.WriteLine("Digite a marca do Carro: ");
            //c.marca = Console.ReadLine();
            //Console.WriteLine("Digite o modelo Carro: ");
            //c.modelo = Console.ReadLine();
            //Console.WriteLine("Digite o ano de fabricação do carro: ");
            //c.anoFabricacao= int.Parse(Console.ReadLine());

            //Console.WriteLine("Marca: " + c.marca + "\nmodelo: " + c.modelo + "\nano fabricação: " + c.anoFabricacao + "\n");

            //Carro c1 = new Carro(); // instanciando um objeto
            //Console.WriteLine("Digite a marca do Carro: ");
            //c1.marca = Console.ReadLine();
            //Console.WriteLine("Digite o modelo Carro: ");
            //c1.modelo = Console.ReadLine();
            //Console.WriteLine("Digite o ano de fabricação do carro: ");
            //c1.anoFabricacao = int.Parse(Console.ReadLine());

            //Console.WriteLine("Marca: " + c1.marca + "\nmodelo: " + c1.modelo + "\nano fabricação: " + c1.anoFabricacao + "\n");

            Livro l = new Livro();
            Console.WriteLine("Digite o titulo do livro:");
            l.titulo = Console.ReadLine() + "\n";
            Console.WriteLine("Digite o autor do livro:");
            l.autor = Console.ReadLine() + "\n";
            Console.WriteLine("Digite o ano de publicação do livro:");
            l.anoPublicacao = Console.ReadLine() + "\n";

            Console.WriteLine("Titulo:"+l.titulo+"\nAutor:"+l.autor+"\nano publicação:"+l.anoPublicacao+"\n");
        }
    }
}

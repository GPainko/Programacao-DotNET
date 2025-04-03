namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String nome, cpf;
            int dia, mes, ano;
            DateTime dataNasc;

            Console.WriteLine("Digite seu nome:");
            nome = Console.ReadLine();

            Console.WriteLine("Digite seu CPF:");
            cpf = Console.ReadLine();

            Console.WriteLine("Digite dia de Nascimento");
            dia = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite mes de Nascimento");
            mes = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite ano de Nascimento");
            ano = int.Parse(Console.ReadLine());

            dataNasc = new DateTime(ano, mes, dia);

            Pessoa p = new Pessoa(nome,cpf,dataNasc);

            Console.Clear();
            p.apresentarDados();
        }
    }
}

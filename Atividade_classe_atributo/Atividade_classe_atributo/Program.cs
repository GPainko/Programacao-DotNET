namespace Atividade_classe_atributo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 - Crie uma classe "Jogo" com os seguintes atributos: Título, Gênero, Plataforma
            //(por exemplo, PC, Xbox, PlayStation), Ano de lançamento. Na main, instancie um objeto
            //e faça a leitura pelo teclado.
            Console.WriteLine("Atividade 1:");
            Jogo jogo = new Jogo();

            Console.WriteLine("Digite o Titulo do jogo:");
            jogo.titulo = Console.ReadLine();

            Console.WriteLine("Digite o Genero do jogo:");
            jogo.genero = Console.ReadLine();

            Console.WriteLine("Digite a plataforma do jogo:");
            jogo.plataforma = Console.ReadLine();

            Console.WriteLine("Digite o Ano de lancamento do jogo:");
            jogo.anoLancamento = int.Parse(Console.ReadLine());

            Console.WriteLine("-------------------------");
            Console.WriteLine("Titulo = " + jogo.titulo);
            Console.WriteLine("Genero = " + jogo.genero);
            Console.WriteLine("Plataforma = " + jogo.plataforma);
            Console.WriteLine("ano de lancamento = " + jogo.anoLancamento);
            Console.WriteLine("-------------------------");

            Console.WriteLine("Atividade 2:");

            // 2 - Crie uma classe "Estúdio" com os seguintes atributos:
            // Nome, Ano de fundação, País de origem e Número de jogos produzidos.
            // Na main, instancie um objeto e faça a leitura pelo teclado.
            
            Estudio estudio = new Estudio();

            Console.WriteLine("Digite o Nome do estudio:");
            estudio.nome = Console.ReadLine();

            Console.WriteLine("Digite o Ano da fundação do estudio:");
            estudio.anoFundacao = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o pais de origem do estudio:");
            estudio.paisOrigem = Console.ReadLine();

            Console.WriteLine("Digite o Numero de jogos produzidos do estudo:");
            estudio.numeroJogosProduzidos = int.Parse(Console.ReadLine());

            Console.WriteLine("-------------------------");
            Console.WriteLine("Nome = " + estudio.nome);
            Console.WriteLine("Ano de Fundação = " + estudio.anoFundacao);
            Console.WriteLine("Pais de Origem = " + estudio.paisOrigem);
            Console.WriteLine("Numero de jogos produzidos = " + estudio.numeroJogosProduzidos);
            Console.WriteLine("-------------------------");

            Console.WriteLine("Atividade 3:");

            // 3 - Crie uma classe chamada Carro que possua 3 atributos:
            // marca, modelo e anoFabricacao.
            // Além disso, na main crie 2 objetos do tipo Carro e exibir na tela os valores dos atributos criados.
            // Esses valores devem ser solicitados ao usuário, no programa.

            Carro carro1 = new Carro();

            Console.WriteLine("Digite a Marca do Carro:");
            carro1.marca = Console.ReadLine();

            Console.WriteLine("Digite o modelo do carro:");
            carro1.modelo = Console.ReadLine();

            Console.WriteLine("Digite o ano de fabricacao do carro:");
            carro1.anoFabricacao = int.Parse(Console.ReadLine());

            Console.WriteLine("-------------------------");
            Console.WriteLine("Marca: " + carro1.marca);
            Console.WriteLine("Modelo = " + carro1.modelo);
            Console.WriteLine("Ano de fabricação = " + carro1.anoFabricacao);
            Console.WriteLine("-------------------------");

            Carro carro2 = new Carro();

            Console.WriteLine("Digite a Marca do Carro:");
            carro2.marca = Console.ReadLine();

            Console.WriteLine("Digite o modelo do carro:");
            carro2.modelo = Console.ReadLine();

            Console.WriteLine("Digite o ano de fabricacao do carro:");
            carro2.anoFabricacao = int.Parse(Console.ReadLine());

            Console.WriteLine("-------------------------");
            Console.WriteLine("Marca: " + carro2.marca);
            Console.WriteLine("Modelo = " + carro2.modelo);
            Console.WriteLine("Ano de Fabricação = " + carro2.anoFabricacao);
            Console.WriteLine("-------------------------");

        }
    }
}

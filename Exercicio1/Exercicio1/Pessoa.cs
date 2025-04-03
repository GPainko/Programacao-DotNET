using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    internal class Pessoa
    {
        public string nome;
        public string cpf;
        public DateTime dataNascimento;

        public Pessoa(string mome, string cpf, DateTime dataNascimento)
        {
            this.nome = mome;
            this.cpf = cpf;
            this.dataNascimento = dataNascimento;
        }

        public void apresentarDados()
        {
            Console.WriteLine("Nome:" + this.nome);
            Console.WriteLine("Cpf:" + this.cpf);
            Console.WriteLine("Data de Nascimento:" + this.dataNascimento.ToString("d"));
        }
    }
}

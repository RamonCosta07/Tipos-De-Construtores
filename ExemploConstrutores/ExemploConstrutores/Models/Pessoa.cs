using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploConstrutores.Models
{
    class Pessoa
    {
        /* Readonly ele só é possível ser alterado no
         * momento da inicialização ou através do
         * construtor
         */
        private readonly string nome;
        private readonly string sobrenome;

        //public Pessoa()
        //{
        //    nome = string.Empty; // string vazia
        //    sobrenome = string.Empty;
        //}
        public Pessoa(string nome, string sobrenome)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            Console.WriteLine("Construtor da classe Pessoa\n");
        }

        public void Apresentar()
        {
            Console.WriteLine($"Me chamo: {nome} {sobrenome}");
        }
    }
}

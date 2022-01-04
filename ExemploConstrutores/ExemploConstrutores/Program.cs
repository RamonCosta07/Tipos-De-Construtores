using ExemploConstrutores.Models;
using System;

namespace ExemploConstrutores
{
    class Program
    {
        public delegate void Operacao(int x, int y); // Criando um delegate. Um parâmetros do método e do delegate tem que ser =
        static void Main(string[] args)
        {
            Aluno p1 = new Aluno("Ramon", "Costa", "Matemática");
            p1.Apresentar();
            Pessoa p2 = new Pessoa("Roger", "Ackyold");
            p2.Apresentar();
            Console.WriteLine();

            Log log = Log.GetInstance();
            log.PropriedadeLog = "Teste intância";
            Log log2 = Log.GetInstance();
            Console.WriteLine(log2.PropriedadeLog);
            Console.WriteLine();

            Console.WriteLine("     Utilizando Get e Set com mês      ");
            Data data = new Data();
            Data data2 = new Data();

            //data.SetMes(13);
            data.Mes = 11;
            Console.WriteLine($"Utilizando o Get para retornar o valor do Mês: {data.Mes}");
            data2.Mes = 14;
            data.ApresentarMes();
            data2.ApresentarMes();

            Console.WriteLine();
            Console.WriteLine("Utilizando delegate com os métodos da classe Calculadora: ");
            Operacao op = new Operacao(Calculadora.Somar); // Usando o método de calculadora no Delegate op
            //Operacao op = Calculadora.Somar; // Outra forma de chamar o Delegate
            op += Calculadora.Subtrair; // Multi cast delegate (Chamar mais de um método em uma única chamada)
            op.Invoke(15, 10); // invocando o método com o Delegate
            //op(15, 10); // outra forma de chamar o Delegate
            Console.WriteLine();
            Console.WriteLine("...Evento....");
            Matemática m = new Matemática(10, 10);
            m.Somar();


        }
    }
}

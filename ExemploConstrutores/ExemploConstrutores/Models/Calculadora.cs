using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploConstrutores.Models
{
    class Calculadora
    {
        // Delegate
        public delegate void DelegateCalculadora();

        // Evento
        public static event DelegateCalculadora EventoCalculadora;

        public static void Somar(int x, int y)
        {
            if(EventoCalculadora != null) // Se houver inscritos
            {
                Console.WriteLine($"Soma: {x + y}");
                EventoCalculadora(); // Vai executar todos os métodos inscritos nesse Evento
            }
            else
            {
                Console.WriteLine("Nenhum Inscrito!");
            }
            
        }

        public static void Subtrair(int x, int y)
        {
            Console.WriteLine($"Subtração: {x - y}");
        }
    }
}

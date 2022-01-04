using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploConstrutores.Models
{
    class Matemática
    {
        public int x { get; set; }
        public int y { get; set; }

        public Matemática(int x, int y)
        {
            this.x = x;
            this.y = y;
            /* Quando ocorrer uma ação na classe calculadora
             * Ela irá chamar esse evento.
             * Consequentemente ele irá chamar o EventHandler
             */
            Calculadora.EventoCalculadora += EventHandler;
        }

        public void Somar()
        {
            Calculadora.Somar(x, y);
        }

        public void EventHandler()
        {
            Console.WriteLine("Método executado");
        }
    }
}

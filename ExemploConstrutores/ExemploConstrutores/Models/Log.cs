using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploConstrutores.Models
{
    class Log
    {
        private static Log _log;
        public string PropriedadeLog { get; set; }
        private Log() // Construtor Privado
        {
        }

        public static Log GetInstance()
        {
            if(_log == null)
            {
                _log = new Log();
            }
            return _log; // Irá ser sempre a mesma intância, independentemente de quantas vezes for chamado
        }
    }
}

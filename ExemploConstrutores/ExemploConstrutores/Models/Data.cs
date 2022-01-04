using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploConstrutores.Models
{
    class Data
    {
        private int mes;
        private bool mesValido;
        public int Mes // Não precisamos declarar variável privada caso não desejarmos criar validações
        {
            get
            {
                return this.mes;
            }
            set
            { 
                /* Value é o valor após o sinal de = quando utilizamos o Set
                 */
                if(value > 0 && value < 13)
                {
                    this.mes = value;
                    this.mesValido = true;
                }
            }
        } 

        //public int GetMes(int mes)
        //{
        //    return this.mes;
        //}
        //public void SetMes(int mes)
        //{
        //    if (mes > 0 && mes < 13)
        //    {
        //        this.mes = mes;
        //        this.mesValido = true;
        //    }
        //}

        public void ApresentarMes()
        {
            if (this.mesValido)
            {
                Console.WriteLine("Mês: " + mes);
            }
            else
            {
                Console.WriteLine("Mês: inválido");
            }
        }
    }
}

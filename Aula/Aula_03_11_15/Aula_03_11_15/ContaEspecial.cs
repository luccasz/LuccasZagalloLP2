using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_03_11_15
{
    class ContaEspecial : ContaBancaria
    {
        public double limite { get; set; }

        public void Sacar()
        {
            if(saldo == limite)
            {
                Console.WriteLine("Saldo no valor do limite!!!");
            }
            else
            {
                Console.WriteLine("Saldo menor que o limite!!!");
            }
        }
    }
}

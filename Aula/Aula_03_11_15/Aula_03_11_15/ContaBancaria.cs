using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_03_11_15
{
    class ContaBancaria
    {
        public string cliente { get; set; }
        public int numConta { get; set; }
        public double saldo { get; set; }

        public void Sacar(double sqe)
        {
            if(saldo > 0 && saldo >= sqe)
                saldo = saldo - sqe;
            else
                Console.WriteLine("Saldo negativo!!!");
        }
        public void Depositar(double dpst) 
        {
            saldo = saldo + dpst;
        }
    }
}

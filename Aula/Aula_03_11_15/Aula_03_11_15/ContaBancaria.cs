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
  
        public void Depositar(double deposito) 
        {
            saldo += deposito;
            Console.WriteLine("Depositou R${0} ", deposito);
        }
        public void Sacar(double saque, double limite)
        {
            saldo = saldo - saque;
            Console.WriteLine("Sacou R${0}", saque);

            Console.WriteLine("Limite R${0}", limite);

            if(saldo + limite < saque)
            {
                Console.WriteLine("Saldo Insfuciente!!!");
            }
        }
    }
}

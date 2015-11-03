using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_03_11_15
{
    class ContaPoupanca : ContaBancaria
    {
        public string diaRendimento { get; set; }

        public void CalculaNovoSaldo(double rendimento)
        {
            double porcento = rendimento * saldo;
            double novoSaldo = porcento + saldo;
            Console.WriteLine("Novo Saldo: " + novoSaldo);
        }
    }
}

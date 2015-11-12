using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_03_11_15
{
    class ContaPoupanca : ContaBancaria
    {
        public int diaRendimento { get; set; }

        public void CalculaNovoSaldo(double rend, int diaRendimento)
        {
            double percentual = rend * diaRendimento;
            saldo = saldo * (1 + percentual / 100);
        }
    }
}

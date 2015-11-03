using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_03_11_15
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria banco = new ContaBancaria();
            double deposito = double.Parse(Console.ReadLine());
            banco.Depositar(deposito);

            double limite = double.Parse(Console.ReadLine());
            double saque = double.Parse(Console.ReadLine());
            banco.Sacar(saque, limite);

            ContaPoupanca poupanca = new ContaPoupanca();
            double rendimento = double.Parse(Console.ReadLine());
            poupanca.CalculaNovoSaldo(rendimento);
        }
    }
}

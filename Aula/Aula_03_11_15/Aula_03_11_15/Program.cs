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
            banco.cliente = Console.ReadLine();
            banco.numConta = int.Parse(Console.ReadLine());
            banco.saldo = double.Parse(Console.ReadLine());

            double saque = double.Parse(Console.ReadLine());
            banco.Sacar(saque);
            Console.WriteLine("Saldo Cliente: R${0}", banco.saldo);
            double deposito = double.Parse(Console.ReadLine());
            banco.Depositar(deposito);

            Console.WriteLine(" ");
            Console.WriteLine("----Dados Conta do Usuário!!----");
            Console.WriteLine("Nome Cliente: {0}", banco.cliente);
            Console.WriteLine("Número Conta: {0}", banco.numConta);
            Console.WriteLine("**Saldo Atual Cliente: R${0}", banco.saldo);
            Console.WriteLine(" ");

            ContaEspecial especial = new ContaEspecial();
            Console.WriteLine("Valor do Limite:");
            especial.limite = double.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            ContaPoupanca poupanca = new ContaPoupanca();
            Console.WriteLine("Rendimento:");
            double rendimento = double.Parse(Console.ReadLine());
            Console.WriteLine("Dia do rendimento:");
            int diaDoRendimento = int.Parse(Console.ReadLine());
            poupanca.CalculaNovoSaldo(rendimento, diaDoRendimento);
        }
    }
}

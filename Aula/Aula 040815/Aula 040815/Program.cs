using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_040815
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Nome = Console.ReadLine();
            pessoa.Cpf = Console.ReadLine();
            pessoa.DataNascimento = DateTime.Parse(Console.ReadLine());
            pessoa.Placa = Console.ReadLine();
            pessoa.Credito = double.Parse(Console.ReadLine());
            pessoa.AddCredito();

            Console.WriteLine("");
            Console.WriteLine("Nome: {0}",pessoa.Nome);
            Console.WriteLine("CPF: {0}",pessoa.Cpf);
            Console.WriteLine("Data Nascimento: {0}", pessoa.DataNascimento.ToLongDateString());
            Console.WriteLine("Placa: {0}", pessoa.Placa);
            Console.WriteLine("Créditos: {0}", pessoa.Credito);
            Console.WriteLine("CRÉDITO ADICIONADO: {0}", pessoa.AddCredito());
        }
    }
}

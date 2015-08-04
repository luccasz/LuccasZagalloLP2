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

            Console.WriteLine(pessoa.Nome);
            Console.WriteLine(pessoa.Cpf);
            Console.WriteLine(pessoa.DataNascimento);
            Console.WriteLine(pessoa.Placa);
            Console.WriteLine(pessoa.Credito);
            Console.WriteLine(pessoa.AddCredito());
        }
    }
}

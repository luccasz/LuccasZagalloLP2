using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();

            List <Funcionario> funcinarios = new List<Funcionario>();
            
            f.Nome = Console.ReadLine();
            f.Cpf = Console.ReadLine();
            f.Nascimento = DateTime.Parse(Console.ReadLine());
            f.Salario = double.Parse(Console.ReadLine());
            f.Matricula = Console.ReadLine();

            funcinarios.Add(f);

            Console.WriteLine(f.Nome);
            Console.WriteLine(f.Cpf);
            Console.WriteLine(f.Nascimento);
            Console.WriteLine(f.Salario);
            Console.WriteLine(f.Matricula);
        }
    }
}

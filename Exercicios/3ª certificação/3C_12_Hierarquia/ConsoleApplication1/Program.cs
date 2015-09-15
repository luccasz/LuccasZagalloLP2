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

            List <Funcionario> funcionarios = new List<Funcionario>();
            
            f.Nome = Console.ReadLine();
            f.Cpf = Console.ReadLine();
            f.Nascimento = DateTime.Parse(Console.ReadLine());
            f.Salario = double.Parse(Console.ReadLine());
            f.Matricula = Console.ReadLine();

            funcionarios.Add(f);

            foreach (var item in funcionarios)
            {
                Console.WriteLine(item);    
            }
            
        }
    }
}

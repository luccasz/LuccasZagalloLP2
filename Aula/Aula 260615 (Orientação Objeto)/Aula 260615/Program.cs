using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_260615
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Funcionario f = new Funcionario();

            for (int i = 0; i < n; i++)
            {
                f.nome = Console.ReadLine();
                f.cpf = Console.ReadLine();
                f.dtNascimento = DateTime.Parse(Console.ReadLine());
                f.dtAdmissao = DateTime.Parse(Console.ReadLine());
                f.salario = double.Parse(Console.ReadLine());

                Console.WriteLine(" ");
                Console.WriteLine("Nome: {0} ", f.nome);
                Console.WriteLine("CPF: {0} ", f.cpf);
                Console.WriteLine("Nascimento: {0} ", f.dtNascimento);
                Console.WriteLine("Admissão: {0} ", f.dtAdmissao);
                Console.WriteLine("Salário: {0} ", f.salario);
                Console.WriteLine("Novo Salário: {0}", f.CalculaAumento());
            }

            //Console.WriteLine(f.InicialDoNome());       
            
            /* int[] funcionarios = new int[n];
            string[] nome = new string[n];
            string[] cpf = new string[n];
            DateTime[] dtNascimento = new DateTime[n];
            DateTime[] dtAdmissao = new DateTime[n];
            double[] salario = new double[n];
            double[] novoSalario = new double[n];
          
            for (int i = 0; i < n; i++)
            {
                nome[i] = Console.ReadLine();
                cpf[i] = Console.ReadLine();
                dtNascimento[i] = DateTime.Parse(Console.ReadLine());
                dtAdmissao[i] = DateTime.Parse(Console.ReadLine());
                salario[i] = double.Parse(Console.ReadLine());
            }
            */
        }
    }
}

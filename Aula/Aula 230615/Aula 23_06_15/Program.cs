using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_23_06_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] funcionario = new int[n];

            for (int i = 0; i < n; i++)
            {
                string nome = Console.ReadLine();
                string cpf = Console.ReadLine();
                DateTime dtNacimento = Convert.ToDateTime(Console.ReadLine());
                double salario = int.Parse(Console.ReadLine());
                int dtAdmissao = int.Parse(Console.ReadLine()); 

                if(dtAdmissao >= 2014)
                {
                    double aumento = 423.45;
                    salario = salario + aumento;
                    Console.WriteLine("{0} ficou com {1} ", nome, salario);
                }
                if(dtAdmissao > 2009 && dtAdmissao < 2014)
                {
                    double aumento = 9.84 / 100;
                    salario = salario + aumento;
                    Console.WriteLine("{0}  ficou com  {1} ", nome, salario);
                }
                if (dtAdmissao > 1999 && dtAdmissao < 2010)
                {
                    double aumento = 16.4 / 100;
                    salario = salario + aumento;
                    Console.WriteLine("{0} ficou com {1} ", nome, salario);
                }
                if (dtAdmissao <= 1999)
                {
                    double aumento = 22.6 / 100;
                    salario = salario + aumento;
                    Console.WriteLine("{0} ficou com {1} ", nome, salario);
                }
            }

        }
    }
}

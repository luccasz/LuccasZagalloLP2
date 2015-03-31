using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc1
{
    class Program
    {
        static void Main(string[] args)
        {
            double soma = 0;
            double media = 0;
            int contador = 0;

            Console.WriteLine("Digite a quantidade de numeros");
            int qtd = int.Parse(Console.ReadLine());

            double[] num = new double[qtd];

            for (int i = 0; i < qtd; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
            }

            foreach (var positivo in num)
            {
                if (contador < qtd)
                {
                    soma += num[contador];
                    contador++;
                }
            }

            media = soma / qtd;
            Console.WriteLine("A média é: " + media);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Faça um programa que leia do usuário um número N.
               Em seguida, devem ser lidos N números positivos.
               Seu programa deve determinar a soma destes números, o maior e o menor 
               entre eles, e exibir estes resultados. */

            Console.WriteLine("Digite a qtd de números");
            int qtd = int.Parse(Console.ReadLine());
            int soma = 0;
            int num = 0;

            int maior = 0;
            int menor = 0;

            for (int i = 0; i < qtd; i++)
            {
                Console.WriteLine("Digite um número");
                num = int.Parse(Console.ReadLine());

                soma += num;

                if (num < menor || i == 0)
                {
                    menor = num;
                }
                if (num > maior || i == 0)
                {
                    maior = num;
                }
            }
            Console.WriteLine("Soma: " + soma);
            Console.WriteLine("Maior Número: " + maior);
            Console.WriteLine("Menor Número: " + menor);
            Console.ReadKey();
        }
    }
}

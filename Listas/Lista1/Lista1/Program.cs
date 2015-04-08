using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fatorial());
            Console.WriteLine(Soma1aN());
            Console.WriteLine(Ex3());
            Console.WriteLine(Ex6());
        }

        static string Fatorial()
        {
            /*Faça um programa que leia um número N e calcule o fatorial desse número.
             Fat(N) = N! = N × (N − 1) × (N − 2) × ⋯ × 3 × 2 × 1 */

            int num = int.Parse(Console.ReadLine());

            int fatorial = 1;

            for (int i = 0; i < num; i++)
            {
                fatorial = fatorial * (num - i); 
            }
            return num + "!" + "=" + fatorial;
        }

        static int Soma1aN()
        {
            /* leia um número N e calcule e mostre como resposta a soma de todos os números 
               inteiros entre 1 e N. */

            int n = int.Parse(Console.ReadLine());

            int i, soma = 0;

                for (i = 0; i < n; i++)
                {
                    soma = soma + i;
                }
            return soma;         
        }

        static int Ex3()
        {
            /* Leia o número de funcionários (> 0) de uma empresa e, em seguida, leia o nome 
               e o salário atuais de cada um deles. Você deve calcular o novo salário
               e mostrar o nome, o salário atual e o salário reajustado de cada funcionário. */

            int numero = int.Parse(Console.ReadLine());

            int acrescimo = 0;
            int salarioFinal = 0;

            for (int i = 0; i < numero; i++)
            {
                    int salario = int.Parse(Console.ReadLine());

                    string nome = Console.ReadLine();

                    if (salario >= 0 && salario < 3000)
                    {
                        acrescimo = 25/100;
                        salarioFinal = salario + (acrescimo * salario);
                    }

                    if (salario >= 3000 && salario < 4000)
                    {
                        acrescimo = 20 / 100;
                        salarioFinal = salario + (acrescimo * salario);
                    }

                    if (salario >= 4000 && salario < 5000)
                    {
                        acrescimo = 15 / 100;
                        salarioFinal = salario + (acrescimo * salario);
                    }

                    if (salario >= 5000)
                    {
                        acrescimo = 10 / 100;
                        salarioFinal = salario + (acrescimo * salario);
                    }              
            }
            return salarioFinal;
        }

        static int Ex6()
        {
            /* a. Leia o nome e a altura de mulheres inscritas em um concurso de beleza. 
               Para cada uma, existe uma linha de entrada contendo seu nome e sua altura (em centímetros). 
               A entrada termina COM A PALAVRA “FIM” no lugar do nome.
               b. Calcule e escreva as 2 maiores alturas e quantas das moças as possuem. */

            int nMulher = int.Parse(Console.ReadLine());  

            while (nMulher > 0)
            {
                string nome = Console.ReadLine();

                int altura = int.Parse(Console.ReadLine());  
            }
            return nMulher;
        }
    }
}

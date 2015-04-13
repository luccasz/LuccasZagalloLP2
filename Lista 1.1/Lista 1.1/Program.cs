using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ex6());           
        }

        static int ex6()
        { 
            /* a. Leia o nome e a altura de mulheres inscritas em um concurso de beleza.
               Para cada uma, existe uma linha de entrada contendo seu nome e sua altura (em centímetros). 
               A entrada termina COM A PALAVRA “FIM” no lugar do nome.
               b. Calcule e escreva as 2 maiores alturas e quantas das moças as possuem. */

            int num = int.Parse(Console.ReadLine());
            double maior = 0;
  
            while (num > 0)
            {
                string nome = Console.ReadLine();
                double altura = double.Parse(Console.ReadLine());
                
                if (altura > maior)
                {
                    maior = altura;
                }
                num--;
            }
            Console.WriteLine("Maior altura entre as participantes é {0}cm", maior);
            return num;
        }

        static double ex3()
        {
            /* Leia o número de funcionários (> 0) de uma empresa e, em seguida, leia o nome 
             e o salário atuais de cada um deles. Você deve calcular o novo salário
             e mostrar o nome, o salário atual e o salário reajustado de cada funcionário. */

            int numero = int.Parse(Console.ReadLine());
            double percent_aumento = 0;
            double novo_salario = 0;

            while (numero > 0)
            {
                double salario_atual = double.Parse(Console.ReadLine());
                string nome = Console.ReadLine();

                if (salario_atual >= 0 && salario_atual < 3000)
                {
                    percent_aumento = salario_atual * 0.25;
                    novo_salario = salario_atual + percent_aumento;
                    Console.WriteLine("O funcionário {0}, teve um aumento de R$ {1}, e agora seu salário é: R${2}", nome, percent_aumento, novo_salario);
                }

                if (salario_atual >= 3000 && salario_atual < 4000)
                {
                    percent_aumento = salario_atual * 0.20;
                    novo_salario = salario_atual + percent_aumento;
                    Console.WriteLine("O funcionário {0}, teve um aumento de R$ {1}, e agora seu salário é: R${2}", nome, percent_aumento, novo_salario);
                }

                if (salario_atual >= 4000 && salario_atual < 5000)
                {
                    percent_aumento = salario_atual * 0.15;
                    novo_salario = salario_atual + percent_aumento;
                    Console.WriteLine("O funcionário {0}, teve um aumento de R$ {1}, e agora seu salário é: R${2}", nome, percent_aumento, novo_salario);
                }

                if (salario_atual >= 5000)
                {
                    percent_aumento = salario_atual * 0.10;
                    novo_salario = salario_atual + percent_aumento;
                    Console.WriteLine("O funcionário {0}, teve um aumento de R$ {1}, e agora seu salário é: R${2}", nome, percent_aumento, novo_salario);
                }
                numero--;
            }
            return novo_salario;
        }

         static double ex10()
         {
             /* Faça um programa que leia um número N e calcule
            e mostre como resposta a soma de todos dos números inteiros entre 1 e N. */

             int n = int.Parse(Console.ReadLine());

             int contador = 0;
             int soma = 0;

             for (contador = 0; contador <= n; contador++)
             {
                 soma = n + contador;
             }
             Console.WriteLine(soma);
             // ex 5 
             double qtdLitros = double.Parse(Console.ReadLine());
             double tempo = double.Parse(Console.ReadLine());
             double velocidade = double.Parse(Console.ReadLine());
             double kmLitros = double.Parse(Console.ReadLine());
             double distancia = double.Parse(Console.ReadLine());

             distancia = velocidade * tempo;
             Console.WriteLine("A distancia percorrida é {0}", distancia);

             qtdLitros = distancia / kmLitros;
             Console.WriteLine("A qtd de litros gasto é {1}", qtdLitros);
             return distancia;
         }
    }
}

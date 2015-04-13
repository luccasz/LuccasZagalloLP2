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
            Console.WriteLine(Funcionario());
            Console.WriteLine(Fatorial());
            Console.WriteLine(Soma1aN());
            Console.WriteLine(ConcursoBeleza());
        }

        static string Fatorial()
        {
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
            int n = int.Parse(Console.ReadLine());
            int i, soma = 0;

                for (i = 0; i <= n; i++)
                {
                    soma = soma + i;
                }
            return soma;         
        }

        static double Funcionario()
        {
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

        static int ConcursoBeleza()
        {
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
    }
}

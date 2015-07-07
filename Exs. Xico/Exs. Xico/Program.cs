using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs.Xico
{
    class Program
    {
        static void Main(string[] args)
        {
            ex5();
        }
        static void ex1()
        {
            //1) Faça um programa que leia o nome e a idade de uma pessoa .O programa deve exibir como resposta a frase "<nome> tem <idade> anos."
            string nome = Console.ReadLine();
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("{0} tem {1} anos.", nome, idade);
        }
        static void ex2()
        {
            /*2) Faça um programa que leia o raio de um círculo/esfera.  //P= 2.pi.r  //A = pi * r²  //V = 4. π. r³/3  //AS = pi * 4r^2 
                 O programa deve exibir como resposta o perímetro e a área do círculo e o volume e área superficial da esfera.*/
            double raio = double.Parse(Console.ReadLine());
            double pi = 3.14;
            double perimetro = 2 * pi * raio;
            Console.WriteLine("Perimetro do circulo é {0}.", perimetro);

            double area = pi * (raio * raio);
            Console.WriteLine("Area do circulo é {0}.", area);

            double volume = 4 * pi * (raio * raio * raio) / 3; 
            Console.WriteLine("Volume da esfera é {0}.", volume);

            double areaSuperficial =pi * 4 * (raio * raio);
            Console.WriteLine("Area superficial da esfera é {0}.", areaSuperficial);

            Console.ReadKey();
        }
        static void ex3()
        {
            /*3) Faça um programa que leia uma seqüência de números naturais terminada em 0.
                 O programa deve imprimir os quadrados de cada um dos números, ignorando o 0. */

            int valor = 0;
            int[] seq = new int[1000];
            int[] quad = new int[1000];

            int ponteiro = 0, i = 0;
            bool continua = true;
           
            while(continua == true)
            {
                valor = int.Parse(Console.ReadLine());

                if(valor == 0)
                {
                    continua = false;
                }
                else
                {
                    seq[ponteiro] = valor; //guardar o valor digitado

                    valor = valor * valor; //o quadrado do valor

                    quad[ponteiro] = valor; //guarda o quadrado do valor

                    ponteiro++; 
                }
            }
            for(i = 0; i < ponteiro; i++)
            {
                Console.WriteLine("O qudrado do numero {0} é {1}", seq[i], quad[i]);
            }
            Console.ReadKey();
        }
        static void ex4()
        {
            /*4) Faça um programa que leia um numero de entre 1 e 1000 (inclusive). Imprima a "tabuada" desse número.
                 Ex: 7
                 7 x 1 = 7
                 7 x 2 = 14
                 7 x 3 = 21
                 7 x 4 = 28
                    .
                    .
                 7 x 999 = 6993
                 7 x 1000 = 7000 */
            int num = int.Parse(Console.ReadLine());
            int tabuada = 0;

            for(int i = 1; i <= 1000; i ++)
            {
                tabuada = num * i;
                Console.WriteLine("{0} x {1} = {2}", num, i, tabuada);
            }
        }
        static void ex5()
        {
            /*5) Faça um programa que leia um número inteiro positivo e imprima este número convertido para base 2 (ou seja, em binário)
                 Ex: 14
                 14(10) = 1110(2) */  
            int num = int.Parse(Console.ReadLine());
            int divisao = 0, sobra = 0;

            int[] resto = new int[1000];

            int contador;
            contador = 0;

            bool continua = true;

            while (continua == true)
            {
                divisao = num / 2;

                if (divisao == 0)
                {
                    continua = false;
                    resto[contador] = 1;
                }
                else
                {
                    sobra = num % 2; //resto de uma divisao

                    resto[contador] = sobra;
                    contador++;
                    num = divisao;
                }
            }
            for(int i = contador; i >= 0; i--)
            {
                Console.Write(resto[i]);
            }
            Console.ReadKey();
        }
    }
}

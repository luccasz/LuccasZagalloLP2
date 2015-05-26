using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_apoio
{
    class Program
    {
        static void Main(string[] args)
        {
           // ex1();
           // ex2();
              ex3();
        }
        static void ex1()
        {
            // leia um numero N, P e Q, inteiros, imprima todos os multiplos de N na intervalo [P,Q] (ou seja, entre P e Q, inclusive eles)
            int n = 0, p = 0, q = 0;
            n = int.Parse(Console.ReadLine());
            p = int.Parse(Console.ReadLine());
            q = int.Parse(Console.ReadLine());

            for (int i = p; i <= q; i++)
            {
                if (i % n == 0)
                    Console.WriteLine(i);
            }
        }
        static void ex2()
        {
            /* leia um nro N inteiro. Em seguida leia N vezes os 3 lados de um triangulo e decida para cada um, se ele é escaleno,
           isósceles ou equilatero. Caso seja escaleno, determine se ele retangulo */
            int n = 0, ladoA = 0, ladoB = 0, ladoC = 0;
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                ladoA = int.Parse(Console.ReadLine());
                ladoB = int.Parse(Console.ReadLine());
                ladoC = int.Parse(Console.ReadLine());

                if (ladoA == ladoB && ladoB == ladoC && ladoA == ladoC)
                {
                    Console.WriteLine("Triângulo Equilátero");
                }
                else if (ladoA == ladoB || ladoA == ladoC)
                {
                    Console.WriteLine("Triângulo Isósceles");
                }
                else if (ladoA != ladoB && ladoB != ladoC && ladoC != ladoA)
                {
                    Console.WriteLine("Triângulo Escaleno");
                }
            }
        }
        static void ex3()
        {
            int n = 0, par = 0, impar = 1, p = 0, s = 0;
            n = int.Parse(Console.ReadLine());

            int[] array = new int[n];
            for (int i = 0; i < n; i++)
                array[i] = int.Parse(Console.ReadLine());

            for(p = 0; p < n; p++)
            {
                par += array[p];
                p++;
            }
            for (s = 1; s < n; s++)
            {
                impar += array[s];
                s++;
            }
            if (par > impar)
                Console.WriteLine("Par");
            if(impar > par)
                Console.WriteLine("Impar");
            if(impar == par)
                Console.WriteLine("Neutra");
        }
    }
}

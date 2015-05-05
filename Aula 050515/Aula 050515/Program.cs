using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_050515
{
    class Program
    {
        static void Main(string[] args)
        {
            /* continue o programa abaixo dada 4 coordenadas (x1 e y1 ) e (x2 e y2) de n pontos no plano (n dado pelo usuario),
               ache o vetor de maior tamanho 
               int n = int.Parse(Console.ReadLine());
               int[] x1 = new int[n];
               int[] y1 = new int[n];
               int[] x2 = new int[n];
               int[] y2 = new int[n]; */

            /* int[,] ponto1 = new int[n, 2]; // vao ser 2 pq ele vai ler duas coordenadas ou seja duas dimensoes 
               int[,] ponto2 = new int[n, 2]; */

            int n = int.Parse(Console.ReadLine());

            int[] x1 = new int[n];
            int[] y1 = new int[n];
            int[] x2 = new int[n];
            int[] y2 = new int[n];

            for (int i = 0; i < n; i++)
            {
                x1[i] = int.Parse(Console.ReadLine());
                y1[i] = int.Parse(Console.ReadLine());
                x2[i] = int.Parse(Console.ReadLine());
                y2[i] = int.Parse(Console.ReadLine());
            }

            double maior = double.MinValue;
            int j = 0;
            for (int i = 0; i < n; i++)
            {
                int cat1 = x2[i] - x1[i];
                int cat2 = y2[i] - y1[i];
                double hip = cat1 * cat1 + cat2 * cat2;
                hip = Math.Sqrt(hip);

                if (hip > maior)
                {
                    maior = hip;
                    j = i;
                }
            }
            Console.WriteLine("({0}, {1}), ({2}, {3})", x1[j], y1[j], x2[j], y2[j]);
            Console.WriteLine(maior);



            // descubra para q serve o programa
            /*int x = int.MinValue;
            int[] v = { 0, 0, 0, 0, 0 };
            int k = 0;

            int num = int.Parse(Console.ReadLine());

            while (num > 0 && num <= v.Length)
            {
                v[num] += 1;
                num = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < v.Length; i++)
            {
                Console.WriteLine("{0} : {1}", i + 1, v[i]); // valor {0}  na posição indicada {1}
                if (v[i] > x)
                {
                    x = v[i];
                    k = i;

                }
                Console.WriteLine("{0}", k + 1);
            } */
        }
    }
}

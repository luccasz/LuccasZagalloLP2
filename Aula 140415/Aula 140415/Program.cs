using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_140415
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nadadores = new string[5];
            double[,] vet = new double[3, 5]; 
            string[] vencedor = new string[3];
            double[] tVencedor = new double[3];
            double[] tTotal = new double[5]; 
            double tCampeao = 0;
            string campeao = " ";

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Nadadores");
                nadadores[i] = Console.ReadLine();
            }
            for (int j = 0; j < 3; j++)
            {
                for (int x = 0; x < 5; x++)
                {
                    vet[j, x]  = double.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int x = 0; x < 5; x++)
                {
                    if (vet[i, x] < tVencedor[i])
                        tVencedor[i] = vet[i, x];
                        vencedor[i] = nadadores[x];
                }
            }
            for (int i = 0; i < 5; i++)
            {
                tTotal[i] = vet[0, i] + vet[1, i] + vet[2, i];
            }
            for (int i = 0; i < 5; i++)
            {
                if (tTotal[i] < tCampeao)
                {
                    tCampeao = tTotal[1];
                    campeao = nadadores[i];
                }   
            }
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("{0} ganhou a prova {1}.", vencedor[i], i + 1);
            }
            Console.WriteLine("Campeão é: {0}", campeao);
            Console.WriteLine("Tempo total {0}s", tCampeao);
        }
    }
}

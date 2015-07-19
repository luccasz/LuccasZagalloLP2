using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_280415
{
    class Program
    {
        static void Main(string[] args)
        {
            // ler um array de numero inteiro e escrever em ordem crescente
            int num = 0, i = 0, aux = 0, j = 0;
            Console.WriteLine("Digite um numero");
            num = int.Parse(Console.ReadLine());

            int[] array = new int[num];

            for(i = 0; i < num; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            for(i = 0; i < num; i++)
            {
                for (j = 0; j < num; j++)
                    if (array[i] < array[j])
                    {
                        aux = array[i];
                        array[i] = array[j];
                        array[j] = aux;
                    }
            }

            for (i = 0; i < num; i++)
            {
                Console.WriteLine(array[i]);
            }            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_020615
{
    class Program
    {
        static void Main(string[] args)
        {
            Palindromo();
            //NroTriangular();
        }
        static void Palindromo()
        {
            //ler uma string e escrever ao contrario
            string letra = Console.ReadLine();

            for (int i = letra.Length - 1; i >= 0; i--)
            {
                Console.Write(letra[i]);
            }
            Console.ReadLine();
        }
        static void NroTriangular()
        {
            //em andamento......
            int n = int.Parse(Console.ReadLine());
            int i = 1, prod = 0;

            while(n!= 0)
            {
                prod = i * (i + 1) * (i + 2);
                i++;

                if (prod == n)
                {
                    Console.WriteLine("Triangular");
                }
                else
                {
                    Console.WriteLine("Não Triangular");
                }              
            }        
        }
    }
}

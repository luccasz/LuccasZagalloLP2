
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisão
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MeuNome());

            int n = int.Parse(Console.ReadLine());
               Console.WriteLine("Soma é: {0}", CalculaSomaDeUmAN(n));
        }

        //nome

        static string MeuNome()
        {
            return "CP";
        }

        //soma de um à n

        static int CalculaSomaDeUmAN(int numero)                                                                                                                          
        {
            int soma = 0;

            for (int i = 1; i <= numero; i++)
            {
                soma += i;
            }
            return soma;
        }


        //números pares 
        static bool EhPar(int num)
        {

            if (num % 2 == 0)
            {
                return true;           //    método 1
            }
            return false;
        }  

        //números multiplos de 3

        static bool EhMult3(int num)
        {
            return num % 3 == 0;      //     método 2
        }

        //números multiplos de n

        static bool EhMult(int num , int n)
        {
            return num % n == 0;
        }
    }
}                                                                   
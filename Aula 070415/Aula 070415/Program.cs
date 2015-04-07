using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_070415
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = Console.ReadLine();

            int n = int.Parse(Console.ReadLine());

            string tmp = Console.ReadLine();
            char c = tmp[0];

            for (int i = 0; i < frase.Length; i += n)
            {
                if (i + n > frase.Length)
                    Console.WriteLine(frase.Substring(i));
                else
                    Console.WriteLine(frase.Substring(i, n));
            }

            string[] palavras = frase.Split(' ');

            int qtd = 0;
            for (int i = 0; i < frase.Length; i++)
            {
                if (palavras[i][0] == c)
                    qtd++;

            }
            Console.WriteLine(qtd);
        }
    }
}

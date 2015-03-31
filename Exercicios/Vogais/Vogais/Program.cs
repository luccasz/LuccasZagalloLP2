using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vogais
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, x;
            string[] vogais = new string[10] { "a", "e", "i", "o", "u", "A", "E", "I", "O", "U" };
            int total = 0;

            string texto;
            Console.WriteLine("Digite uma frase: ");
            texto = Console.ReadLine();

            for (i = 0; i <= texto.Length - 1; i++) 
                for (x = 0; x <= 9; x++) 
                {
                    if (Convert.ToString(texto.Substring(i, 1)) == vogais[x])
                    {
                        total++;
                    }
                }
            Console.Write("A mensagem tem " +total+ " vogais.");
            Console.ReadKey();         
        }
    }
}

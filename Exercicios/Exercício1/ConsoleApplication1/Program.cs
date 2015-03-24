using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite números para média para concluir:");
            var num = int.Parse(Console.ReadLine());
            int soma = 0;
            int quant = 0;
            double media = 0;
 
            while (num > 0)
            {   
                quant++;
                soma += num;
                num = int.Parse(Console.ReadLine());
            }
            
            media = soma / quant;
            Console.WriteLine("Média: {0}", media);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_310315
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o coeficiente");
            int coeficiente = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o expoente");
            int expoente = int.Parse(Console.ReadLine());

            int resultado = 1;
            if (coeficiente == 0)
            {
                resultado = 0;
            }
            else
                for (int i = 0; i < expoente; i++)
                {
                    resultado *= coeficiente;
                }
            Console.WriteLine(resultado);         
            Console.ReadKey();
        }

    }
}

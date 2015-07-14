using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_140715
{
    class Program
    {
        static void Main(string[] args)
        {
            Cachorro fido = new Cachorro();
            fido.tamanhoCm = 95; // 1 cm = 0,01 m
            fido.SetNome("Fido");
            fido.SetPeso(42.3);

            Console.WriteLine("Nome: {0}", fido.GetNome());
             Console.WriteLine("Peso: {0}", fido.GetPeso());
             Console.WriteLine("Tamanho (m): {0}", fido.tamanhoCm/100);

            // qtd ração = peso(kg) / tamanho(m)²
            Console.WriteLine("Quantidade diária de ração: {0}", fido.RacaoDiariaKg());   

        }
    }
}

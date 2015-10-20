using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Exercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Opções: (1)Cadastrar / (2)Consultar / (0)SAIR");
            int opcao = int.Parse(Console.ReadLine());

            while (opcao != 0)
            {
                if (opcao == 1)
                {
                    Cadastro();
                }
                else if (opcao == 2)
                {
                    Consulta();
                }
            }
        }

        public static void Cadastro()
        {
            Pessoas p = new Pessoas();
            dal dal = new dal();

            p.Nome = Console.ReadLine();
            p.Sobrenome = Console.ReadLine();
            p.Peso = double.Parse(Console.ReadLine());
            p.Altura = double.Parse(Console.ReadLine());
            p.Telefone = Console.ReadLine();

            dal.Cadastro(p);
        }

        public static void Consulta()
        {
            Pessoas p = new Pessoas();
            dal da = new dal();

            Console.WriteLine("(1)Consultar por ID / (2)Consultar por Nome");
            int consulta = int.Parse(Console.ReadLine());

            while (consulta != 0)
            {
                if (consulta == 1)
                {
                    da.ConsultaId();
                }
                else if (consulta == 2)
                {
                    da.ConsultaNome();
                }
            }
        }       
    }
}

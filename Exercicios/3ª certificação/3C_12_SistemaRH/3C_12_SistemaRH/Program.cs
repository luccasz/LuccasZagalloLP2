using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3C_12_SistemaRH
{
    class Program
    {
        static void Main(string[] args)
        {
            int numTrabalhador = int.Parse(Console.ReadLine());
            double pagamentoEmpresa = 0;

            Funcionario f = new Funcionario();
            Gerente g = new Gerente();
            Terceirizado t = new Terceirizado();

            List<Funcionario> funcionarios = new List<Funcionario>();
            List<Gerente> gerentes = new List<Gerente>();
            List<Terceirizado> terceirizados = new List<Terceirizado>();

            int countF = 0, countG = 0, countT = 0, l = 0;

            for (int i = 0; i < numTrabalhador; i++)
            {
                Console.WriteLine("Escolha o tipo de trabalhador: 'funcionario', 'gerente' ou 'terceirizado'");
                string tpTrabalhador = Console.ReadLine();

                if (tpTrabalhador == "funcionario") {
                    f.Nome = Console.ReadLine();
                    f.Cpf = Console.ReadLine();
                    f.DataNascimento = Console.ReadLine();
                    f.Matricula = Console.ReadLine();
                    Console.WriteLine(" ");
                    funcionarios.Add(f);
                    countF++;
                }

                if (tpTrabalhador == "gerente") {
                    g.Nome = Console.ReadLine();
                    g.Cpf = Console.ReadLine();
                    g.DataNascimento = Console.ReadLine();
                    g.Matricula = Console.ReadLine();
                    g.AreaGerencia = Console.ReadLine();
                    Console.WriteLine(" ");
                    gerentes.Add(g);
                    countG++;
                }

                if (tpTrabalhador == "terceirizado") {
                    t.Nome = Console.ReadLine();
                    t.Cpf = Console.ReadLine();
                    t.DataNascimento = Console.ReadLine();
                    t.Matricula = Console.ReadLine();
                    t.Cnpj = Console.ReadLine();
                    Console.WriteLine(" ");
                    terceirizados.Add(t);
                    countT++;
                }
            }
            Console.WriteLine("_______FICHA DA EMPRESA______");
                if (countF > 0)
                {
                    Console.WriteLine("Funcionarios: ");
                    for (l = 0; l < countF; l++)
                    {
                        Console.WriteLine("Nome: {0}", funcionarios[l].Nome);
                        Console.WriteLine("Cpf: {0}", funcionarios[l].Cpf);
                        Console.WriteLine("Nascimento: {0}", funcionarios[l].DataNascimento);
                        Console.WriteLine("Matricula: {0}", funcionarios[l].Matricula);
                        Console.WriteLine("Salario: {0}", funcionarios[l].Salario());
                        Console.WriteLine("Vale Alimentação: {0}", funcionarios[l].ValeAlimentacao());
                        Console.WriteLine(" ");

                        pagamentoEmpresa += funcionarios[l].Salario() + funcionarios[l].ValeAlimentacao();
                    }
                }
                if (countG > 0)
                {
                    Console.WriteLine("Gerentes: ");
                    for (l = 0; l < countG; l++)
                    {
                        Console.WriteLine("Nome: {0}", gerentes[l].Nome);
                        Console.WriteLine("Cpf: {0}", gerentes[l].Cpf);
                        Console.WriteLine("Nascimento: {0}", gerentes[l].DataNascimento);
                        Console.WriteLine("Matricula: {0}", gerentes[l].Matricula);
                        Console.WriteLine("Área de Atuação: {0}", gerentes[l].AreaGerencia);
                        Console.WriteLine("Salario: {0}", gerentes[l].Salario());
                        Console.WriteLine("Vale Alimentação: {0}", gerentes[l].ValeAlimentacao());
                        Console.WriteLine(" ");

                        pagamentoEmpresa += gerentes[l].Salario() + gerentes[l].ValeAlimentacao();
                    }
                }
                if(countT > 0)
                {
                    Console.WriteLine("Terceirizados: ");
                    for(l = 0; l < countT; l++)
                    {
                        Console.WriteLine("Nome: {0}", terceirizados[l].Nome);
                        Console.WriteLine("Cpf: {0}", terceirizados[l].Cpf);
                        Console.WriteLine("Nascimento: {0}", terceirizados[l].DataNascimento);
                        Console.WriteLine("Matricula: {0}", terceirizados[l].Matricula);
                        Console.WriteLine("Cnpj: {0}", terceirizados[l].Matricula);
                        Console.WriteLine(" ");       
                    }
                }
                Console.WriteLine("Pagamento Total da Empresa: {0}", pagamentoEmpresa);
        }
    }
}

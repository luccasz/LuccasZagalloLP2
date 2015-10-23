using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Globalization;

namespace Exercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Opções: (1)Cadastrar / (2)Consultar");
            int opcao = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            MySqlConnection conn = new MySqlConnection("Server=localhost;Database=test;Uid=root;Pwd=luccas");
            conn.Open();
            MySqlCommand command = new MySqlCommand();
            command.Connection = conn;

            while (opcao != 0)
            {
                if (opcao == 1)
                {
                    Console.WriteLine("----OPÇÃO CADASTRO----");
                    Console.WriteLine("Digite na Ordem: 1-Nome/ 2-Sobrenome/ 3-Peso/ 4-Altura/ 5-Telefone");

                    Pessoa p = new Pessoa();
                    p.Nome = Console.ReadLine();
                    p.Sobrenome = Console.ReadLine();
                    p.Peso = double.Parse(Console.ReadLine());
                    p.Altura = double.Parse(Console.ReadLine());
                    p.Telefone = Console.ReadLine();
                    Console.WriteLine("USUÁRIO CADASTRADO!!!");
                    Console.WriteLine("");

                    string q = String.Format(new CultureInfo("en"), "INSERT INTO peoples (Nome, Sobrenome, Peso, Altura, Telefone) VALUES ('{0}', '{1}', {2}, {3}, '{4}')", p.Nome, p.Sobrenome, p.Peso, p.Altura, p.Telefone);

                    command.CommandText = q;
                    command.ExecuteNonQuery();                  
                }
                else if (opcao == 2)
                {
                    Console.WriteLine("");
                    Console.WriteLine("----OPÇÃO CONSULTA----");

                    Console.WriteLine("(1)Consultar por Nome / (2)Consultar por ID");
                    int opcaoConsulta = int.Parse(Console.ReadLine());
                    Console.WriteLine("");

                    if (opcaoConsulta == 1)
                    {
                        Console.WriteLine("----Consulta Nome----");

                        Console.WriteLine("Digite um Nome: ");
                        string nome = Console.ReadLine();
                        Console.WriteLine("");

                        string str = string.Format("SELECT * FROM peoples WHERE Nome = '{0}'", nome);
                        command.CommandText = str;

                        MySqlDataReader reader = command.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine("ID:{0}  NOME:{1}  SOBRENOME:{2}",
                                                   reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
                            }                    
                            Console.WriteLine("");
                            Console.WriteLine("---> Deseja ver o registro completo do último usuário criado?? 1-SIM / 0-NÃO");
                            int novo = int.Parse(Console.ReadLine());

                            if (novo != 0)
                            {
                                Console.WriteLine("ID:{0}  NOME:{1}  SOBRENOME:{2}  PESO:{3}  ALTURA:{4}  TELEFONE:{5}",
                                                   reader.GetInt32(0), reader.GetString(1), reader.GetString(2),
                                                   reader.GetDouble(3), reader.GetDouble(4), reader.GetString(5));
                            }
                            Console.WriteLine("");
                        }
                        else
                        {
                            Console.WriteLine("Não existe o NOME {0} no sistema!!", nome);
                            Console.WriteLine("");
                        }
                        reader.Close();
                    }
                    else if (opcaoConsulta == 2)
                    {
                        Console.WriteLine("----Consulta ID----");

                        Console.WriteLine("Digite um ID: ");
                        int id = int.Parse(Console.ReadLine());
                        Console.WriteLine("");

                        string str = string.Format("SELECT * FROM peoples WHERE Id = '{0}'", id);
                        command.CommandText = str;

                        MySqlDataReader reader = command.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine("ID:{0}  NOME:{1}  SOBRENOME:{2}  PESO:{3}  ALTURA:{4}  TELEFONE:{5}",
                                                   reader.GetInt32(0), reader.GetString(1), reader.GetString(2),
                                                   reader.GetDouble(3), reader.GetDouble(4), reader.GetString(5));
                            }
                        }
                        else
                        {
                            Console.WriteLine("INFORMAÇÃO IMPORTANTE: Não existe o ID {0} no sistema!!", id);
                            Console.WriteLine("");
                        }
                        reader.Close();
                    }
                }
                Console.WriteLine("");
                Console.WriteLine("Opções: (1)Cadastrar / (2)Consultar");
                opcao = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                if(opcao != 1 && opcao != 2)
                {
                    conn.Close();
                    Console.WriteLine("SAIU DO SISTEMA!!!");
                    break;
                }
                else
                {
                    continue;
                }
            }   
        }
    }
}

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

            MySqlConnection conn = new MySqlConnection("Server=localhost;Database=test;Uid=root;Pwd=luccas");
            conn.Open();
            MySqlCommand command = new MySqlCommand();
            command.Connection = conn;

            while (opcao != 0)
            {
                if (opcao == 1)
                {
                    Console.WriteLine("----Opção Cadastro----");

                    Pessoa p = new Pessoa();
                    p.Nome = Console.ReadLine();
                    p.Sobrenome = Console.ReadLine();
                    p.Peso = double.Parse(Console.ReadLine());
                    p.Altura = double.Parse(Console.ReadLine());
                    p.Telefone = Console.ReadLine();

                    string q = String.Format(new CultureInfo("en"), "INSERT INTO peoples (Nome, Sobrenome, Peso, Altura, Telefone) VALUES ('{0}', '{1}', {2}, {3}, '{4}')", p.Nome, p.Sobrenome, p.Peso, p.Altura, p.Telefone);

                    command.CommandText = q;
                    command.ExecuteNonQuery();
                    conn.Close();

                    opcao = int.Parse(Console.ReadLine());
                }
                else if (opcao == 2)
                {
                    Console.WriteLine("----Opção Consulta----");

                    Console.WriteLine("(1)Consultar por Nome / (2)Consultar por ID");
                    int opcaoConsulta = int.Parse(Console.ReadLine());

                    if (opcaoConsulta == 1)
                    {
                        Console.WriteLine("----Opção Consulta Nome----");

                        Console.WriteLine("Digite um Nome: ");
                        string nome = Console.ReadLine();

                        string str = string.Format("SELECT * FROM peoples WHERE Nome = '{0}'", nome);
                        command.CommandText = str;

                        MySqlDataReader reader = command.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                if (reader.GetString(1) == nome)
                                {
                                    Console.WriteLine("Id: {0}, Nome: {1}, Sobrenome: {2}, Peso: {3}, Altura: {4}, Telefone: {5} ",
                                                       reader.GetInt32(0), reader.GetString(1), reader.GetString(2),
                                                       reader.GetDouble(3), reader.GetDouble(4), reader.GetString(5));
                                }
                            }
                        }
                        reader.Close();
                    }
                    else if(opcaoConsulta == 2)
                    {
                        Console.WriteLine("----Opção Consulta ID----");

                        Console.WriteLine("Digite um ID: ");
                        int id = int.Parse(Console.ReadLine());

                        string str = string.Format("SELECT * FROM peoples WHERE Id = '{0}'", id);
                        command.CommandText = str;

                        MySqlDataReader reader = command.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                if (reader.GetInt32(0) == id)
                                {
                                    Console.WriteLine("Id: {0}, Nome: {1}, Sobrenome: {2}, Peso: {3}, Altura: {4}, Telefone: {5} ",
                                                       reader.GetInt32(0), reader.GetString(1), reader.GetString(2), 
                                                       reader.GetDouble(3), reader.GetDouble(4), reader.GetString(5));
                                }
                            }
                        }
                        reader.Close();
                    }
                }
            }   
        }
    }
}

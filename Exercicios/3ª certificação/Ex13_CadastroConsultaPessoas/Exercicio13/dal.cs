using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Exercicio13
{
    class dal
    {
        MySqlConnection conexao = new MySqlConnection("Server=localhost;Database=test;Uid=root;Pwd=luccas");
        MySqlCommand command  = new MySqlCommand();

        public void Cadastro(Pessoas p)
        {
            try
            {
                conexao.Open();

                string inserir = string.Format(new CultureInfo("en"), "INSERT INTO people (Nome, Sobrenome, Peso, Altura, Telefone) VALUES ('{0}', '{1}', {2}, {3}, '{4}')", p.Nome, p.Sobrenome, p.Peso, p.Altura, p.Telefone);

                command.Connection = conexao;
                command.CommandText = inserir;
                command.ExecuteNonQuery();
                conexao.Close();            
            }
            catch (Exception ex) 
            {          
                throw new Exception ("Erro de Comandos: " + ex.Message);
            }
        }
        public void ConsultaNome()
        {
            Console.WriteLine("Digite um Nome: ");
            string nome = Console.ReadLine();
            string str = string.Format("SELECT {0} INTO Nome FROM people", nome);

            conexao.Open();
            command.Connection = conexao;
            command.CommandText = str;

            MySqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    if (reader.GetString(1) == nome)
                    {
                        Console.WriteLine("Id: {0}, Nome: {1}, Sobrenome: {2}, Peso: {3}, Altura: {4}, Telefone: {5} ", reader.GetInt64(0), reader.GetString(1), reader.GetString(2), reader.GetDouble(3), reader.GetDouble(4), reader.GetString(5));
                    }
                }
            }
            reader.Close();
        }

        public void ConsultaId()
        {
            Console.WriteLine("Digite um ID: ");
            int id = int.Parse(Console.ReadLine());
            string strr = string.Format("SELECT {0} INTO Id FROM people", id);

            conexao.Open();
            command.Connection = conexao;
            command.CommandText = strr;

            MySqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    if (reader.GetInt32(0) == id)
                    {
                        Console.WriteLine("Id: {0}, Nome: {1}, Sobrenome: {2}, Peso: {3}, Altura: {4}, Telefone: {5} ", reader.GetInt64(0), reader.GetString(1), reader.GetString(2), reader.GetDouble(3), reader.GetDouble(4), reader.GetString(5));
                    }
                    else
                    {
                        Console.WriteLine("Nenhum resultado!!");
                    }
                }
            }
            reader.Close();
        }
    }
}

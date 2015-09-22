using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace AulaBD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um nome para o Banco de Dados Pessoa");
            string nome = Console.ReadLine();

            string strConn = "Server=localhost;Database=test;Uid=root;Pwd=";

            MySqlConnection conn = new MySqlConnection(strConn);

            MySqlCommand command = new MySqlCommand();

            command.Connection = conn;

            command.CommandText = String.Format("INSERT INTO PESSOA (Nome) VALUES ('{0}')", nome); //somente texto pede aspas simples. double e int é sem aspas
             
            conn.Open();

            command.ExecuteNonQuery();

            conn.Close();       
    
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace Aula_29_09_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha uma opção do CRUD: (1-Consultar, 2-Atualizar, 3-Deletar)");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Consultar();
                    break;
                case 2:
                    Atualizar();
                    break;
                case 3:
                    Deletar();
                    break;
                default:
                    break;
            }
        }
        public static void Consultar()
        {
            string c = "INSERT INTO Carro (Marca)";
            ConsultaBD(c);
        }
        public static void Atualizar()
        {
            string a = "";
            ConsultaBD(a);
        }
        public static void Deletar()
        {
            string d = "";
            ConsultaBD(d);
        }

        public static void ConsultaBD(string querry)
        {
            MySqlConnection conn = new MySqlConnection("Server=localhost;Database=test;Uid=root;Pwd=");

            MySqlCommand command = new MySqlCommand();

            command.Connection = conn;

            command.CommandText = querry;

            conn.Open();

            command.ExecuteNonQuery();

            conn.Close();       
        }
    }
}

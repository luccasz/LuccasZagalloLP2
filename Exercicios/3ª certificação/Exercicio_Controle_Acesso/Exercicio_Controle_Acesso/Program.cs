using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Controle_Acesso
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continua = true;

            MySqlConnection conn = new MySqlConnection("Server=localhost;Database=test;Uid=root;Pwd=luccas");
            conn.Open();

            MySqlCommand command = new MySqlCommand();
            command.Connection = conn;

            while (continua)
            {
                Console.WriteLine("Digite seu login e senha, respectivamente");
                string login = Console.ReadLine();
                string senha = Console.ReadLine();

                string str = String.Format("SELECT * FROM usuario WHERE Login = '{0}'", login);
                command.CommandText = str;

                MySqlDataReader reader = command.ExecuteReader();

                var u = new Usuario();
                

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        u.Id = reader.GetInt32(0);
                        u.Nome = reader.GetString(1);
                        u.Email = reader.GetString(2);
                        u.Login = reader.GetString(3);
                        u.Senha = reader.GetString(4);
                        u.Data = reader.GetString(5);

                        var senhaUsu = reader.GetString(4);

                        if (senhaUsu == senha)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("ID: {0} ", u.Id);
                            Console.WriteLine("Nome: {0} ", u.Nome);
                            Console.WriteLine("Email: {0} ", u.Email);
                            Console.WriteLine("Login: {0}", u.Login);
                            Console.WriteLine("Senha: {0}", u.Senha);
                            Console.WriteLine("Data Último Acesso: {0}", u.AtualizaUltimoAcesso(u.Data));

                            Console.WriteLine("");
                            Console.WriteLine("LOGIN EFETUADO COM SUCESSO!!");
                        }
                        else
                        {
                            Console.WriteLine("");
                            Console.WriteLine("USUARIO NÃO CADASTRADO!!");
                        }
                    }
                    reader.Close();
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("USUARIO NÃO CADASTRADO!!");
                    reader.Close();
                }
                Console.WriteLine("");
                Console.WriteLine("Fazer logout?? (sim)");
                string logout = Console.ReadLine();
                Console.WriteLine("");

                if (logout == "sim")
                {
                    continue;
                }
                else
                {
                    continue;
                }
            }
        }
    }
}
      
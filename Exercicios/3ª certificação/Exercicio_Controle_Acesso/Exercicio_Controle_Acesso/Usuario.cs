using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Controle_Acesso
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Data { get; set; }

        public string AtualizaUltimoAcesso(string data)
        {
            MySqlConnection conn = new MySqlConnection("Server=localhost;Database=test;Uid=root;Pwd=luccas");
            conn.Open();

            MySqlCommand command = new MySqlCommand();
            command.Connection = conn;

            var commandString = string.Format("UPDATE usuario SET Data='{0}' WHERE Id='{1}'", DateTime.Now.ToString(), Id);

            command.CommandText = commandString;

            command.ExecuteNonQuery();

            conn.Close();

            return data;
        }
    }
}

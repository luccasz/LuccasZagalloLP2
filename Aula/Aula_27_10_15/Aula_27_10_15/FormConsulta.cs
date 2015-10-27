using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Aula_27_10_15
{
    public partial class FormConsulta : Form
    {
        public Livro livroAchado;

        public FormConsulta()
        {
            InitializeComponent();    
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string isbnBusca = txtBusca.Text;

            MySqlConnection conn = new MySqlConnection("Server=localhost;Database=test;Uid=root;Pwd=");
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;

            string str = String.Format("SELECT * FROM Livro WHERE Isbn = '{0}'", isbnBusca);
            cmd.CommandText = str;

            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    livroAchado = new Livro();

                    livroAchado.Id = reader.GetInt32(0);
                    livroAchado.Titulo = reader.GetString(1);
                    livroAchado.Isbn = reader.GetString(2);
                    livroAchado.Genero = reader.GetString(3);
                    livroAchado.Preco = reader.GetDouble(4);
                    livroAchado.Autor = reader.GetString(5);
                }
            }
            reader.Close();
            conn.Close();

            Close();
        }
    }
}

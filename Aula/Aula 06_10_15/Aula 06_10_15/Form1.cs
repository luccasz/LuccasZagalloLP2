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

namespace Aula_06_10_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Amigo> amigos = new List<Amigo>();

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Amigo c = new Amigo();
            c.Nome = txtNome.Text;
            c.Sobrenome = txtSobrenome.Text;
            c.Presente1 = txtPre1.Text;
            c.Presente2 = txtPre2.Text;
            c.Presente3 = txtPre3.Text;

            amigos.Add(c);
        }
        public void Registro()
        {
            foreach (var item in amigos)
            {
                MySqlConnection conn = new MySqlConnection("Server=localhost;Database=test;Uid=root;Pwd=");

                MySqlCommand command = new MySqlCommand();

                command.Connection = conn;

                string q = String.Format("INSERT INTO AMIGO (Nome, Sobrenome, Presente1, Presente2, Presente3) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')", item.Nome, item.Sobrenome, item.Presente1, item.Presente2, item.Presente3);

                command.CommandText = q;

                conn.Open();

                command.ExecuteNonQuery();

                conn.Close();
            }
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Foram encontrados " +  amigos.Count + " registros");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Registro();
        }

    }
}

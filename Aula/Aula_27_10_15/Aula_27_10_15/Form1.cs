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
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
        }
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            FormConsulta fConsulta = new FormConsulta();
            fConsulta.ShowDialog();

            txtId.Text = fConsulta.livroAchado.Id.ToString();
            txtTitulo.Text = fConsulta.livroAchado.Titulo;
            txtIsbn.Text = fConsulta.livroAchado.Isbn.ToString();
            txtGenero.Text = fConsulta.livroAchado.Genero.ToString();
            txtPreco.Text = fConsulta.livroAchado.Preco.ToString();
            txtAutor.Text = fConsulta.livroAchado.Autor.ToString();
        }
    }
}

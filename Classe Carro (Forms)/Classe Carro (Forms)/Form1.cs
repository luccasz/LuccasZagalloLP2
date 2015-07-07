using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classe_Carro__Forms_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Carro c1 = new Carro();
            c1.placa = txtPlaca.Text;
            c1.modelo = txtModelo.Text;
            c1.consumoKml = double.Parse(txtConsumo.Text);

            MessageBox.Show(c1.placa.ToString());
        }
    }
}

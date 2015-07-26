using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_10_Carros
{
    public partial class Form1 : Form
    {
        List<Carro> listaCarro;

        public Form1()
        {
            InitializeComponent();   
            listaCarro = new List<Carro>();
        }
 
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Carro car = new Carro();
            car.modelo = txtModelo.Text;
            car.placa = txtPlaca.Text;
            car.marca = txtMarca.Text;
            car.ano = int.Parse(txtAno.Text);
            car.kilometragem = double.Parse(txtKm.Text);
            car.capaciTanque = double.Parse(txtTanque.Text);
            car.potencia = double.Parse(txtPotencia.Text);
            listaCarro.Add(car);

            ValidaCadastro();
            LimparCadastro();
        }
        private void LimparCadastro()
        {
            txtAno.Clear();
            txtKm.Clear();
            txtMarca.Clear();
            txtModelo.Clear();
            txtPlaca.Clear();
            txtPotencia.Clear();
            txtTanque.Clear();
        }  
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string id = txtBuscar.Text;

            for (int i = 0; i < listaCarro.Count; i++)
            {
                if (listaCarro[i].placa == id)
                {
                    MessageBox.Show("ESSA PLACA JÁ FOI CADASTRADA!");
                }
                else
                {
                    MessageBox.Show("ESSA PLACA NÃO EXISTE NO NOSSO SISTEMA!");
                }
            }
        }
        private string ValidaCadastro()
        {
            string erro = string.Empty;
            if(string.IsNullOrWhiteSpace(txtModelo.Text))
            {
                erro = "Modelo não pode ser vazio!";
                MessageBox.Show(erro, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if(string.IsNullOrWhiteSpace(txtPlaca.Text))
            {
                erro = "Placa não pode ser vazio nem 0!";
                MessageBox.Show(erro, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (string.IsNullOrWhiteSpace(txtMarca.Text))
            {
                erro = "Marca não pode ser vazio!";
                MessageBox.Show(erro, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if(int.Parse(txtTanque.Text) <= 0)
            {
                erro = "Capacidade do tanque deve ser maior que 0 ou deve ser um número!";
                MessageBox.Show(erro, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (int.Parse(txtAno.Text) <= 0)
            {
                erro = "Ano deve ser maior que 0 ou deve ser um número!";
                MessageBox.Show(erro, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (int.Parse(txtPotencia.Text) <= 0)
            {
                erro = "Potência deve ser maior que 0 ou deve ser um número!";
                MessageBox.Show(erro, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (int.Parse(txtKm.Text) <= 0)
            {
                erro = "Sua kilometragem é 0, então seu carro é novo!";
                MessageBox.Show(erro, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }            
            return erro;
        }
    }
}

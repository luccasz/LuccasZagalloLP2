using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho1
{
    public partial class Cadastro : Form
    {
        private List<Carro> _carros;
        public Cadastro(List<Carro> carros)
        {
            InitializeComponent();
            _carros = carros;
        }

        private void cadastrar_button_Click(object sender, EventArgs e)
        {
            string placa = placa_textbox.Text;
            if (string.IsNullOrWhiteSpace(placa_textbox.Text))
            {
                string erro = "Placa não pode ser vazio!";
                MessageBox.Show(erro, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string marca = marca_textbox.Text;
            if (string.IsNullOrWhiteSpace(marca_textbox.Text))
            {
                string erro = "Marca não pode ser vazio!";
                MessageBox.Show(erro, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string modelo = modelo_textbox.Text;
            if (string.IsNullOrWhiteSpace(modelo_textbox.Text))
            {
                string erro = "Modelo não pode ser vazio!";
                MessageBox.Show(erro, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrWhiteSpace(passageiros_textbox.Text))
            {
                string erro = "Passageiros não pode ser vazio!";
                MessageBox.Show(erro, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }        

            int passageiros;

            try
            {
                passageiros = int.Parse(passageiros_textbox.Text);

                if (passageiros <= 0)
                {
                    string erro = "Passageiros deve ser maior que 0!";
                    MessageBox.Show(erro, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            catch (Exception)
            {
                string erro = "Passageiros deve ser um número inteiro!";
                MessageBox.Show(erro, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Carro car = new Carro()
            {
                ID = _carros.Count + 1,
                Marca = marca,
                Modelo = modelo,
                Capacidade = passageiros,
                Placa = placa
            };

            _carros.Add(car);

            placa_textbox.Clear();
            marca_textbox.Clear();
            modelo_textbox.Clear();
            passageiros_textbox.Clear();
        }
    }
}

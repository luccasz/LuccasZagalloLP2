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
    public partial class Form1 : Form
    {
        private List<Carro> _carros;
        public Form1()
        {
            InitializeComponent();
            _carros = new List<Carro>();           
        }

        private void cadastrar_button_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro(_carros);
            cadastro.ShowDialog();

            mostrar_listbox.Items.Clear();
            for (int i = 0; i < _carros.Count; i++)
            {
                Carro carro = _carros[i];
                atualizaListBox();
            }
        }

        private void atualizaListBox()
        {
            mostrar_listbox.Items.Clear();

            foreach (Carro carro in _carros)
            {
                mostrar_listbox.Items.Add("Carro ID: " + carro.ID);
                mostrar_listbox.Items.Add(" Marca: " + carro.Marca);
                mostrar_listbox.Items.Add(" Modelo: " + carro.Modelo);
                mostrar_listbox.Items.Add(" Placa: " + carro.Placa);
                mostrar_listbox.Items.Add(" Vagas: " + (carro.Capacidade - carro.Passageiros).ToString());
                mostrar_listbox.Items.Add("-----");
            }
        }
        private void pesquisarId_button_Click(object sender, EventArgs e)
        {
            int id;
            try
            {
                id = int.Parse(pesquisarId_textbox.Text);
            }
            catch
            {
                MessageBox.Show("ID deve ser um número inteiro!");
                return;
            }

            foreach(Carro carro in _carros)
            {
                if(carro.ID == id)
                {
                    if (carro.Capacidade > carro.Passageiros)
                    {
                        carro.Passageiros++;
                        atualizaListBox();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Carro lotado");
                        return;
                    }
                }
            }
            MessageBox.Show("ID inválido");
        } 
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio11_Viagem
{
    public class Carro
    {
        public Carro(int _id, string _modelo, string _marca, string _placa, int _capacidade)
        {
            this.p_id = _id;
            this.p_modelo = _modelo;
            this.p_marca = _marca;
            this.p_placa = _placa;
            this.p_capacidade = _capacidade;
            this.p_ocupacao = _capacidade;
        }

        private int p_id = -1;
        private string p_modelo = String.Empty;
        private string p_marca = String.Empty;
        private string p_placa = String.Empty;
        private int p_ocupacao = 0;
        private int p_capacidade = 0;

        public int ID
        {
            get { return p_id; }
            set { p_id = value; }
        }

        public string modelo
        {
            get { return p_modelo; }
            set { p_modelo = value; }
        }

        public string marca
        {
            get { return p_marca; }
            set { p_marca = value; }
        }

        public string placa
        {
            get { return p_placa; }
            set { p_placa = value; }
        }

        public int ocupacao
        {
            get { return p_ocupacao; }
            set { p_ocupacao = value; }
        }

        public int capacidade
        {
            get { return p_capacidade; }
            set
            {
                p_capacidade = value;
                p_ocupacao = value;
            }
        }

        public string AlocaPassageiro()
        {
            if (p_ocupacao == 0)
            {
                return "Carro lotado!!";
            }
            else 
            {
                p_ocupacao--;
                return "Alocação realizada";
            }
        }
    }
}

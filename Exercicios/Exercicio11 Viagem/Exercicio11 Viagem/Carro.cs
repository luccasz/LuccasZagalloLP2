using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio11_Viagem
{
    public class Carro
    {
        private int _id = -1;
        private string _modelo = String.Empty;
        private string _marca = String.Empty;
        private string _placa = String.Empty;
        private int _ocupacao = 0;
        private int _capacidade = 0;

        public Carro (int id, string modelo, string marca, string placa, int capacidade)
        {
            _id = id;
            _modelo = modelo;
            _marca = marca;
            _placa = placa;
            _capacidade = capacidade;
            _ocupacao = capacidade;
        }
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Modelo
        {
            get { return _modelo; }
            set { _modelo = value; }
        }
        public string Marca
        {
            get { return _marca; }
            set { _marca = value; }
        }
        public string Placa
        {
            get { return _placa; }
            set { _placa = value; }
        }
        public int Ocupacao
        {
            get { return _ocupacao; }
            set { _ocupacao = value; }
        }
        public int Capacidade 
        {
            get { return _capacidade; }
            set
            {
                _capacidade = value;
                _ocupacao = value;
            }
        }

        public string AlocaPassageiro()
        {
            if (_ocupacao == 0)
            {
                return "Carro lotado!!";
            }
            else 
            {
                _ocupacao--;
                return "Alocação realizada";
            }
        }
    }
}

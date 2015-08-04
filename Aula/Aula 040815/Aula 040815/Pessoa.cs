using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_040815
{
    public class Pessoa 
    {
        /*string nome, string cpf. datetime dtnascimento, string placa carro, double creditos
        criar metodos para: - ADD CREDITOS 
        - PAGAR O VALOR DO ESTACIONAMENTO
        esse metodo recebe o valor da hr atual , o tempo em minutos de permanencia. Não há tolerancia */

        private string _nome;
        private string _cpf;
        private DateTime _dtNascimento;
        private string _placa;
        private double _credito;

        public Pessoa() { } //criar isso sempre
        public Pessoa (string nome, string cpf, DateTime dtNascimento, string placa, double credito)
        {
            _nome = nome;
            _cpf = cpf;
            _dtNascimento = dtNascimento;
            _placa = placa;
            _credito = credito;
        }
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        public string Cpf
        {
            get { return _cpf; }
            set { _cpf = value; }
        }
        public DateTime DataNascimento
        {
            get { return _dtNascimento; }
            set { _dtNascimento = value; }
        }
        public string Placa
        {
            get { return _placa; }
            set { _placa = value; }
        }
        public double Credito
        {
            get { return _credito; }
            set { _credito = value; }
        }

        public double AddCredito()
        {
            double creditoNulo = 0;
            if(_credito > 0)
            {
                return _credito;
            }
            else
            {
                return creditoNulo;      
            }
        }
    }
}

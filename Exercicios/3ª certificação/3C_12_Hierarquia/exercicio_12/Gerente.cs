using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_12
{
    class Gerente
    {
        public string Nome { get; set; }
        public int Cpf { get; set; }
        public int DataNascimento { get; set; }
        public int Salario { get; set; }
        public int Matricula { get; set; }
        public string Area{ get; set; }
        public int Adicional { get; set; }
        public int SalarioTotal { get; set; }

        public void AumentoSalarial(int Salario, int Adicional, int SalarioTotal)
    {
        SalarioTotal = Salario + Adicional;
    }
    }
}

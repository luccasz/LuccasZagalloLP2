using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3C_12_SistemaRH
{
    class Funcionario : Trabalhador
    {
        private double _salario = 6500;

        public virtual double Salario()
        {
            return _salario;
        }

        public virtual double ValeAlimentacao()
        {
            double valeAlimentacao = 0.08 * Salario();

            if (valeAlimentacao > 750)
            {
                valeAlimentacao = 750;
            }
            return valeAlimentacao;
        }
    }
}

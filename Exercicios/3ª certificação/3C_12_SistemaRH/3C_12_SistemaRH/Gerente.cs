using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3C_12_SistemaRH
{
    class Gerente : Funcionario
    {
        public string AreaGerencia { get; set; }

        Funcionario add = new Funcionario();

        public override double Salario()
        {
            double salarioTotal = add.Salario() + 2000;
            return salarioTotal;
        }

        public override double ValeAlimentacao()
        {
            double valeAlimentacao = 0.065 * Salario();
            
            if (valeAlimentacao > 750)
            {
                valeAlimentacao = 750;
            }
            return valeAlimentacao;
        }
    }
}

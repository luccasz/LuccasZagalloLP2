using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_12
{
    class Gerente:Trabalhador
    {
        public string Area{ get; set; }
        public double Adicional { get; set; }
        public double SalarioTotal
        {
            get
            {
                return Salario + Adicional;
            }
        }

    }
}

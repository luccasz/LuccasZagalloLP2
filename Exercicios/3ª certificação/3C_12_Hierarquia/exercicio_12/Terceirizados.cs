using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_12
{
    class Terceirizados:Trabalhador
    {
        public string Cnpj { get; set; }
        public override double Salario { get; set; }

    }
}

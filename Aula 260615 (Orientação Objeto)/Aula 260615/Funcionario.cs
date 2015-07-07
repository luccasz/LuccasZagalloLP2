using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_260615
{
    public class Funcionario
    {
        public string nome { get; set;}
        public string cpf { get; set; }
        public DateTime dtNascimento { get; set; }
        public DateTime dtAdmissao { get; set; }
        public double salario { get; set; }
        public double novoSalario { get; set; }
        
        /* public char InicialDoNome()
        {
            return nome[0];
        }        
        */      
        public double CalculaAumento()
        {
            if (dtAdmissao.Year >= 2014)
            {
                return salario + 423.45;
            }
            if(dtAdmissao.Year >= 2010 && dtAdmissao.Year <= 2013)
            {
                return salario + 9.84 / 100 * salario;
            }
            if(dtAdmissao.Year >= 2000 && dtAdmissao.Year <= 2009)
            {
                return salario + 16.4 / 100 * salario;
            }
            if(dtAdmissao.Year <= 1999)
            {
                return salario + 22.6 / 100 * salario;
            }
            return salario;
        }
    }
}

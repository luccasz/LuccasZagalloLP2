using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula250815
{
    public class Atleta
    {
        public string Nome { get; set; }
        public int Numero { get; set; }
        public int TempoCs { get; set; }

        public string TempoFormatado
        {
            get {
                return String.Format("{0}: {1}:{2}", TempoCs / 6000, (TempoCs % 6000) / 100, (TempoCs % 6000) % 100);
            }
        }
    }
}

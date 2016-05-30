using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFLP.Entidades
{
    [Serializable]
    public class Atomica
    {

        public string Nome { get; set; }
        public bool Negado { get; set; }
        public bool? Valor { get; set; }
    }
}

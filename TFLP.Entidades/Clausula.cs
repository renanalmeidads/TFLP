using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFLP.Entidades
{
    [Serializable]
    public class Clausula
    {

        public List<Atomica> Atomicas { get; set; }

        public Clausula()
        {
            Atomicas = new List<Atomica>();
        }

        public Clausula(Clausula clausula)
        {
            this.Atomicas = clausula.Atomicas;
        }

    }
}

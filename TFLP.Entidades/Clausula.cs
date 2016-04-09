using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFLP.Entidades
{
    public class Clausula
    {

        public List<Atomica> Atomicas { get; set; }

        public Clausula()
        {
            Atomicas = new List<Atomica>();
        }

    }
}

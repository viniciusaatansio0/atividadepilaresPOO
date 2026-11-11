using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exerHerancaPolimorfismo
{
    public abstract class Entrega
    {
        public int Distancia { get; set; }

        public abstract void CalcularFrete();
    }
}
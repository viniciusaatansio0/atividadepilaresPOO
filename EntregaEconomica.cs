using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exerHerancaPolimorfismo
{
    public class EntregaEconomica : Entrega
    {
        public override double CalcularFrete()
        {
            return Distancia * 1.5;
        }
    }
}
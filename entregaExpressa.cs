using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exerHerancaPolimorfismo
{

    public class entregaExpressa : Entrega
    {

        public int TaxaAdicional { get; set; } = 15;

        public override double CalcularFrete()
        {
            return (Distancia * 2.5) + TaxaAdicional;
        }
    }
}
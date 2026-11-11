using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exerHerancaPolimorfismo
{

    public class entregaExpressa : Entrega
    {
        public override decimal CalcularFrete(decimal frete, decimal taxaAdicional)
        {
            frete = frete + taxaAdicional;

            return frete ;
            }

    }
}
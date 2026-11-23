using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exerHerancaPolimorfismo
{
    public class RetiradaLocal : Entrega
    {
        public override double CalcularFrete()
        {
            return 0.0;
        }
    }
}
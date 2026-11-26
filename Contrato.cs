using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exerHerancaPolimorfismo
{
    public class Contrato : IImprimivel
    {
        public string NumeroContrato { get; set; } = string.Empty;

        public void Imprimir()
        {
            Console.WriteLine($"Imprimindo o contrato de numero {NumeroContrato} em folha canson");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exerHerancaPolimorfismo
{
    public class Notificacao
    {
        public virtual void enviar()
        {
            Console.WriteLine("enviando mensagem");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exerHerancaPolimorfismo
{
    public class NotificacaoSMS : Notificacao
    {
        public override void enviar()
        {
            Console.WriteLine("enviando mensagem no SMS");
        }
    }
}
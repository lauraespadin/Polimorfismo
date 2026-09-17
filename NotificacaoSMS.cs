using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    public class NotificacaoSMS : IInotificacao
    {
        public void Enviar()
        {
            Console.WriteLine("enviando notificação por SMS...");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    public class NotificacaoPush : IInotificacao
    {
        public void Enviar()
        {
            Console.WriteLine("Enviando notificaçao push para o app...");
        }
    }
}

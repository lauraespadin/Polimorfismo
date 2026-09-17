using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    public class NotificacaoEmail : IInotificacao
    {
        public void Enviar()
        {
            Console.WriteLine("Enviando notificação por email...");
        }

        public void Enviar(string anexo)
        {
            Console.WriteLine($"Enviando email com anexo: {anexo}");
        }
    }
}

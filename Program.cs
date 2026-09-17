using Polimorfismo;

namespace Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IInotificacao> notificacoes = new List<IInotificacao>();

            notificacoes.Add(new NotificacaoEmail());
            notificacoes.Add(new NotificacaoSMS());
            notificacoes.Add(new NotificacaoPush());

            foreach (IInotificacao notificacao in notificacoes)
            {
                notificacao.Enviar();
            }

            Console.WriteLine();

            NotificacaoEmail email = new NotificacaoEmail();

            email.Enviar();
            email.Enviar("documento.pdf");
        }
    }
}
using Teste.Domain.Interfaces;

namespace Teste.Domain.Notificacoes
{
    public class Notificador : INotificador
    {
        private List<Notificacao> _notificacoes;


        public Notificador()
        {
            _notificacoes = new List<Notificacao>();
        }
        public void Handle(Notificacao notificacao)
        {
            _notificacoes.Add(notificacao);
        }

        public bool TemNotificacao()
        {
            return _notificacoes.Any();
        }

         public List<Notificacao> ObterNotificacao()
        {
            return _notificacoes;
        }
    }
}

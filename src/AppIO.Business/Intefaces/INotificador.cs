using System.Collections.Generic;
using APPIO.Business.Notificacoes;

namespace APPIO.Business.Intefaces
{
    public interface INotificador
    {
        bool TemNotificacao();
        List<Notificacao> ObterNotificacoes();
        void Handle(Notificacao notificacao);
    }
}
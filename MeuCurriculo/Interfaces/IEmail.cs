using System.Collections.Generic;

namespace MeuCurriculo.Interfaces
{
    public interface IEmail
    {
        void ValidarEmail(string email);
        void EnviarEmail();
        void ValidarMensagem(string mensagem);
        void ValidarEmails(IList<string> emails);
        void EnviarEmail(List<string> para);

    }
}

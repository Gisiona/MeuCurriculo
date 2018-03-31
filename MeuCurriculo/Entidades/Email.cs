using MeuCurriculo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace MeuCurriculo.Entidades
{
    public class Email : Base, IEmail
    {
        private Guid _hashEnvio;
        private string _to;
        private string _para;
        private string _mensagem;

        public string Mensagem
        {
            get { return _mensagem; }
           private set {ValidarMensagem(_mensagem = value); }
        }


        public string Para
        {
            get { return _para; }
           private set {ValidarEmail(_para = value); }
        }


        public string To
        {
            get { return _to; }
            private set {ValidarEmail(_to = value); }
        }


        public Guid HashEnvio
        {
            get { return _hashEnvio; }
            private set { _hashEnvio = value; }
        }

        public void EnviarEmail()
        {
            throw new NotImplementedException();
        }

        public void EnviarEmail(List<string> para)
        {
            throw new NotImplementedException();
        }
        
        public void ValidarEmail(string email)
        {
            if(new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$").IsMatch(email))
            {
                throw new Exception("Email inválido, digite um e-mail válido.");
            }
        }

        public void ValidarEmails(IList<string> emails)
        {
                foreach (string email in emails)
                {
                    ValidarEmail(email.Trim());
                }
        }
        
        public void ValidarMensagem(string mensagem)
        {
            if (mensagem.Length < 10)
            {
                throw new Exception("O mínimo de caracteres do campo mensagem é 10 caracteres.");
            }
        }
    }
}

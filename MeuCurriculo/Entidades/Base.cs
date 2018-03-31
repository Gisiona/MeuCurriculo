using MeuCurriculo.Interfaces;
using System;

namespace MeuCurriculo.Entidades
{
    public abstract class Base:IBase
    {
        public Base()
        {
            _dataCadastro = DateTime.Now;
        }

        private int _codigo;
        private DateTime _dataCadastro;

        public DateTime DataCadastro 
        {
            get { return _dataCadastro; }
            private set { _dataCadastro = value; }
        }


        public int Codigo
        {
            get { return _codigo; }
            private set { _codigo = value; }
        }

        public void ValidarData(DateTime data)
        {
            TimeSpan d = data.Subtract(DateTime.Now);
            if(d.Hours > 5)
            {
                throw new Exception("Data inválida.Por favor verifique a data atual do seu computador.");
            }
        }
    }
}

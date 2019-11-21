using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.ComDesignPattern
{
    public interface IEnviador
    {
        void Enviar(IMensagem mensagem);
    }
}

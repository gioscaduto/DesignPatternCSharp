using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.ComDesignPattern
{
    public interface IMensagem
    {
        IEnviador Enviador { get; set; }

        void Enviar();
        string Formatar();
    }
}

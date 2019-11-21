using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.ComDesignPattern
{
    public class EnviaPorEmail : IEnviador
    {
        public void Enviar(IMensagem mensagem)
        {
            Console.WriteLine("Enviando a mensagem por e-mail");
            Console.WriteLine(mensagem.Formatar());
        }
    }
}

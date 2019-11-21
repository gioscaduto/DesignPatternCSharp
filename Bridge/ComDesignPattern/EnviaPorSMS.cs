using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.ComDesignPattern
{
    public class EnviaPorSMS : IEnviador
    {
        public void Enviar(IMensagem mensagem)
        {
            Console.WriteLine("Enviando a mensagem por SMS");
            Console.WriteLine(mensagem.Formatar());
        }
    }
}

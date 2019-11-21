using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.SemDesignPattern
{
    public class MensagemAdministrativaPorSMS : IMensagem
    {
        public void Enviar()
        {
            Console.WriteLine("Enviando a mensagem por SMS.");
            Console.WriteLine("Mensagem para o Administrador");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.SemDesignPattern
{
    class MensagemAdministrativaPorEmail : IMensagem
    {
        public void Enviar()
        {
            Console.WriteLine("Enviado a mensagem por e-mail");
            Console.WriteLine("Mensagem para o Administrador");
        }
    }
}

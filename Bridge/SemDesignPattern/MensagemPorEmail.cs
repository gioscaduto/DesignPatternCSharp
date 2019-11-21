using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.SemDesignPattern
{
    public class MensagemPorEmail: IMensagem
    {
        private string nome;

        public MensagemPorEmail(string nome)
        {
            this.nome = nome;
        }

        public void Enviar()
        {
            Console.WriteLine("Enviado a mensagem por e-mail");
            Console.WriteLine($"Mensagem para o Cliente: {nome}");
        }
    }
}

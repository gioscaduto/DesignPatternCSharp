using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.SemDesignPattern
{
    class MensagemPorSMS: IMensagem
    {
        private string nome;

        public MensagemPorSMS(string nome)
        {
            this.nome = nome;
        }

        public void Enviar()
        {
            Console.WriteLine("Enviando a mensagem por SMS.");
            Console.WriteLine($"Mensagem para o Cliente {nome}");
        }
    }
}

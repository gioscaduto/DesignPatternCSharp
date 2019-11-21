using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.ComDesignPattern
{
    public class MensagemAdministrativa : IMensagem
    {
        private string nome;
        public IEnviador Enviador { get; set; }

        public MensagemAdministrativa(string nome)
        {
            this.nome = nome;
        }

        public void Enviar()
        {
            Enviador.Enviar(this); 
        }

        public string Formatar()
        {
            return $"Enviado a mensagem para o administrador {nome}";
        }
    }
}

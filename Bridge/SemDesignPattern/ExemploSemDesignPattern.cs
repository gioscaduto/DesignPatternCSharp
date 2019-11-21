using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.SemDesignPattern
{
    public class ExemploSemDesignPattern
    {
        /* Problemas 
         * Cada novo Tipo de Mensagem (No nosso exemplo: Administrativa), precisamos adicionar 2 classes.
         * Uma classe para o envio por Email e a outra por SMS.
         * As classes de mensagens estao com muitas responsabilidades, escolher a forma de envio e formatar a mensagem 
         * Uma solucao e dividir em 2 hieraquias, um Enviador e uma Mensagem que sabe se formatar. 
         */
        public static void Executar()
        {
            IMensagem mensagemPorEmailCliente = new MensagemPorEmail("João");
            IMensagem mensagemPorSmsCliente = new MensagemPorSMS("João");

            IMensagem mensagemAdministrativaPorEmail = new MensagemAdministrativaPorEmail();
            IMensagem mensagemAdministrativaPorSMS = new MensagemAdministrativaPorSMS();

            mensagemPorEmailCliente.Enviar();
            mensagemPorSmsCliente.Enviar();
            mensagemAdministrativaPorEmail.Enviar();
            mensagemAdministrativaPorSMS.Enviar();
        }
    }
}

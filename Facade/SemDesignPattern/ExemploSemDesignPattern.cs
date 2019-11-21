using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.SemDesignPattern
{
    public static class ExemploSemDesignPattern
    {
        /* Exemplo: Utilizando um Sistema Antigo responsavel pelas faturas e cobrancas
         * Problema: 
         * Para utilizar o Sistema Antigo é necessário conhecer varias classes e metodos 
         */
        public static void Executar()
        {
            string cpf = "123.123.123-99";

            Cliente cliente = new ClienteDAL().BuscarPorCpf(cpf);

            Fatura fatura = new Fatura(cliente, 1000);

            Cobranca cobranca = new Cobranca(TipoCobranca.Boleto, fatura);
            cobranca.Emitir();

            ContatoCliente contato = new ContatoCliente(cliente, cobranca);
            contato.Enviar();
        }
    }
}

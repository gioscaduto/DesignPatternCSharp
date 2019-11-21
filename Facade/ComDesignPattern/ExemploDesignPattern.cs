using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.ComDesignPattern
{
    public static class ExemploDesignPattern
    {
        /* O Objetivo do Façade é isolar em uma classe a complexidade de acesso à um Sistema Legado por exemplo
         * No exemplo abaixo, apenas precisamos conhecer a classe EmpresaFacade
         * Problemas do Facade:
         * A Classe Facade pode ficar bastante complexa com o decorrer do tempo
         * (Muitos Metodos e Regras de Negocio)
         */
        public static void Executar()
        {
            string cpf = "123.123.123-99";

            EmpresaFacade facade = new EmpresaFacade();

            Cliente cliente = facade.BuscarCliente(cpf);

            var fatura = facade.CriarFatura(cliente, 1000);
            var cobranca = facade.GerarCobranca(TipoCobranca.Boleto, fatura);

            facade.RealizarContato(cliente, cobranca);
        }
    }
}

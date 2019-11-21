using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.ComDesignPattern
{
    public static class ExemploDesignPattern
    {
        /* O Singleton e similar ao Design Pattern FlyWeight, porem o Singleton e responsavel apenas por um objeto
         * Com o Singleton utilizamos o mesmo objeto em todas as partes da aplicacao 
         * Problema:
         * Este objeto é guardado em uma variavel global, é preciso estar atento para evitar os problemas das variaveis globais 
         */
        public static void Executar()
        {
            string cpf = "123.123.123-99";

            EmpresaFacade facade = EmpresaFacadeSingleton.Instancia;

            Cliente cliente = facade.BuscarCliente(cpf);
        }
    }
}

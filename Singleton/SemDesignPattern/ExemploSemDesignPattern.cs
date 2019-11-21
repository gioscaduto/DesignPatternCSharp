using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.SemDesignPattern
{
    public static class ExemploSemDesignPattern
    {
        /* -- Recomendo Ver o Design Pattern Facade antes de ver este exemplo
         
         * A classe Empresa Facade nao guarda nenhuma variavel ou atributos, apenas metodos
         * Toda vez que precisamos usa-la somos obrigado a instanciar um novo objeto
         * Nao precisamos de varias instancias de Empresa Facade, precisamos de apenas uma instancia
         */
        public static void Executar()
        {
            string cpf = "123.123.123-99";

            EmpresaFacade facade = new EmpresaFacade();

            Cliente cliente = facade.BuscarCliente(cpf);
        }
    }
}

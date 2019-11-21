using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight.SemDesignPattern
{
    public class ExemploSemDesignPattern
    {
        /* Problema identificado
         * Uma mesma classe e instancia mais de uma vez (No caso a Classe Fa)
         * A Classe Fa sempre e a mesma, nao varia, o ideal seria aproveitar o mesmo objeto instanciado 
         * No nosso exemplo a Classe Fa foi instanciada apenas 3 vezes, mas ela poderia ter sido instanciada milhares de vezes
         * Dessa forma seria alocada muita memoria para instanciar varios objetos que sao identicos, o ideal seria reaproveitar esses objetos
         */
        public static void Executar()
        {
            var notas =
            new List<INota>()
            {
                new Do(),
                new Re(),
                new Mi(),
                new Fa(),
                new Fa(),
                new Fa()
            };
        }
    }
}

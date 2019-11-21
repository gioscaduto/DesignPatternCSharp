using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.SemDesignPattern
{
    public class CalculadorDescontos
    {
        public double Calcular(Orcamento orcamento)
        {
            //Mais de 5 itens
            if(orcamento.Itens.Count > 5)
                return orcamento.Valor * 0.1;
            else if(orcamento.Valor > 600){
                return orcamento.Valor * 0.07;
            }
            /* else if
             * else if
             * else if
             
               Muitas Regras de Desconto */

            return 0;
        }

    }
}

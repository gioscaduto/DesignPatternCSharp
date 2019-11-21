using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.SemDesignPattern
{
    public class CalculadorImposto
    {
        public void RealizaCalculo(Orcamento orcamento, IImposto imposto)
        {
            var valorImposto = imposto.Calcular(orcamento);

            Console.WriteLine($"Valor do orçamento: R$ {orcamento.Valor}, Valor do imposto: R$ {valorImposto}.");
        }

        public void RealizaCalculoICMSComIPI(Orcamento orcamento, ICMS impostoICMS, IPI impostoIPI)
        {
            var valorImposto = impostoICMS.Calcular(orcamento) + impostoIPI.Calcular(orcamento);

            Console.WriteLine($"Valor do orçamento: R$ {orcamento.Valor}, Valor do imposto: R$ {valorImposto}.");
        }

        /* Varios Metodos para realizar o calculo da somatoria de varios impostos, muitas combinacoes
         * Por Exemplo: Um metodo para ICMS + IPI, outro metodo para ISS + IPI, assim por diante 
         */
    }
}

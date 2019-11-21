using System;
using System.Collections.Generic;
using System.Text;

namespace State.ComDesignPattern
{
    /* Regras de Descontos
    * Orcamento em 
    * Aprovacao = 5 %
    * Aprovado = 2 %
    * Reprovado = 0 %
    * Finalizado = 0 %
    */
    public class Orcamento
    {
        public IStatusOrcamento Status { get; set; }

        public double Valor { get; set; }

        public Orcamento(double valor)
        {
            this.Valor = valor;
            this.Status = new EmAprovacao();
        }

        public void AplicarDesconto()
        {
            Status.AplicarDesconto(this);
        }

        public void Aprovar()
        {
            Status.Aprovar(this);
        }

        public void Reprovar()
        {
            Status.Reprovar(this);
        }

        public void Finalizar()
        {
            Status.Finalizar(this);
        }   
    }
}

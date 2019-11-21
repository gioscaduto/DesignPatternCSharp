using System;
using System.Collections.Generic;
using System.Text;

namespace State.SemDesignPattern
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
        private const int EM_APROVACAO = 1;
        private const int APROVADO = 2;
        private const int REPROVADO = 3;
        private const int FINALIZADO = 4;

        private int Status { get; set; }

        public double Valor { get; private set; }
        
        public Orcamento(double valor)
        {
            this.Valor = valor;
            this.Status = EM_APROVACAO;
        }

        /* Problema: 
         * Quantidade de ifs conforme aumenta o numero de status
         * Aumento da Complexidade da Classe Orcamentos
         * Repeticao ifs em varios metodos
         * Para um novo status sera necessario implementar a verificacao de Status em todos os metodos 
         */
        public void AplicarDesconto()
        {
            if (Status == EM_APROVACAO)
                Valor = Valor * 0.95;
            else if (Status == APROVADO)
                Valor = Valor * 0.98;
            else
                throw new Exception("Orcamentos com Status Reprovado ou Finalizado nao podem receber desconto.");
        }

        public void AplicarOutroDesconto()
        {
            /* IF STATUS == EM_APROVACAO
             * ELSE IF STATUS APROVADOR
             */
        }
    }
}

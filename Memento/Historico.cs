using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    public class Historico
    {
        /* O Historico poderia guardar os objetos da classe Contrato ao inves da Classe Estado
         * A Classe Estado nao e obrigatoria
         * Implementado desta maneira para manter a forma orginal que o Memento foi descrito
         * Como foi inserida a Classe Estado, coloquei um  atributo nesta classe que contem a Data de Alteracao
         */
        private IList<Estado> Estados  = new List<Estado>();

        //Outra forma de implementacao
        //private IList<Contrato> Contratos = new List<Contrato>();

        public void Adicionar(Estado estado)
        {
            Estados.Add(estado);
        }

        public Estado Obter(int indice)
        {
            return Estados[indice];
        }

        public int QtdEstados => Estados.Count;
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public interface IVisitor
    {
        void VisitaSoma(Soma soma);
        void VisitaSubtracao(Subtracao subtracao);
        void VisitaMultiplicacao(Multiplicao multiplicao);
        void VisitaDivisao(Divisao divisao);
        void VisitaNumero(Numero numero);
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight.ComDesignPattern
{
    public class NotasMusicais
    {
        private IDictionary<string, INota> notas =
            new Dictionary<string, INota>()
            {
                { "do", new Do() },
                { "re", new Re() },
                { "mi", new Mi() },
                { "fa", new Fa() },
                { "sol", new Sol() },
                { "la", new La() },
                { "si", new Si() }
            };

        public INota Obter(string nome)
        {
            return notas[nome];
        }
    }
}

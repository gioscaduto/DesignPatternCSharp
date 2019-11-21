using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight.ComDesignPattern
{
    public class Violao
    {
        public void Tocar(IList<INota> musica)
        {
            foreach (var nota in musica)
            {
                Console.Beep(nota.Frequencia, 300);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight.ComDesignPattern
{
    public static class ExemploDesignPattern
    {
        public static void Executar()
        {
            NotasMusicais notas = new NotasMusicais();

            IList<INota> musica =
            new List<INota>()
            {
                notas.Obter("do"),
                notas.Obter("re"),
                notas.Obter("mi"),
                notas.Obter("fa"), // Objeto Nota Fa Criado Apenas Uma Vez
                notas.Obter("fa"), // Objeto Nota Fa Reutilizado
                notas.Obter("fa")
            };

            Violao violao = new Violao();
            violao.Tocar(musica);
        }
    }
}

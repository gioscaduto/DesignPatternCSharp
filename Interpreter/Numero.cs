using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter
{
    public class Numero: IExpressao
    {
        private int numero;
        public Numero(int numero)
        {
            this.numero = numero;
        }

        public int Avaliar()
        {
            return this.numero;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.SemDesignPattern
{
    public class Cliente
    {
        public string Cpf { get; private set; }

        public Cliente(string cpf)
        {
            Cpf = cpf;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.SemDesignPattern
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

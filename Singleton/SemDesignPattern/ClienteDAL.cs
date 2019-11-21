using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.SemDesignPattern
{
    public class ClienteDAL
    {
        public Cliente BuscarClientePorCpf(string cpf)
        {
            return new Cliente(cpf);
        }
    }
}

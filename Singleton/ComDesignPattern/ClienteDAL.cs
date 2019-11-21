using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.ComDesignPattern
{
    public class ClienteDAL
    {
        public Cliente BuscarClientePorCpf(string cpf)
        {
            return new Cliente(cpf);
        }
    }
}

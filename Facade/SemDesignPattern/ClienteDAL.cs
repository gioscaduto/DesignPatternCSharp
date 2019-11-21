using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.SemDesignPattern
{
    public class ClienteDAL
    {
        public Cliente BuscarPorCpf(string cpf)
        {
            return new Cliente(cpf);
        }
    }
}

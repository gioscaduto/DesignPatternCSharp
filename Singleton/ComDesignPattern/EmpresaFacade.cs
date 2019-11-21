using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.ComDesignPattern
{
    public class EmpresaFacade
    {
        public Cliente BuscarCliente(string cpf)
        {
            return new ClienteDAL().BuscarClientePorCpf(cpf);
        }
    }
}

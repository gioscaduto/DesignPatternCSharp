using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.ComDesignPattern
{
    public static class EmpresaFacadeSingleton
    {
        private static EmpresaFacade facade = new EmpresaFacade();

        public static EmpresaFacade Instancia
        {
            get
            {
                return facade;
            }
        }
    }
}

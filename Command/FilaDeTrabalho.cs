using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public class FilaDeTrabalho
    {
        private IList<IComando> comandos = new List<IComando>();

        public void Adicionar(IComando comando)
        {
            comandos.Add(comando);
        }

        public void Processar()
        {
            foreach (var comando in comandos)
            {
                comando.Executar();
            }
        }
    }
}

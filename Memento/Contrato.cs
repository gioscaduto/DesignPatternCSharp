using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    public class Contrato
    {
        public Contrato(DateTime dt, string cliente, TipoContrato tipo)
        {
            Dt = dt;
            Cliente = cliente;
            Tipo = tipo;
        }

        public DateTime Dt { get; private set; }
        public string Cliente { get; private set; }
        public TipoContrato Tipo { get; private set; }

        public void Avancar()
        {
            if (Tipo == TipoContrato.Novo)
                Tipo = TipoContrato.EmAndamento;
            else if (Tipo == TipoContrato.EmAndamento)
                Tipo = TipoContrato.Acertado;
            else if (Tipo == TipoContrato.Acertado)
                Tipo = TipoContrato.Concluido;
        }

        public void Restaurar(Estado estado)
        {
            Dt = estado.Contrato.Dt;
            Cliente = estado.Contrato.Cliente;
            Tipo = estado.Contrato.Tipo;
        }

        public Estado SalvarEstado()
        {
            return 
                new Estado(new Contrato(Dt, Cliente, Tipo));
        }
    }
}

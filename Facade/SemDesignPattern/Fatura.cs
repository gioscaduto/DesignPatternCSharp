
namespace Facade.SemDesignPattern
{
    public class Fatura
    {
        public Fatura(Cliente cliente, double valor)
        {
            Cliente = cliente;
            Valor = valor;
        }

        public Cliente Cliente { get; private set; }
        public double Valor { get; private set; }
    }
}


namespace ChainOfResponsibility.ComDesignPattern
{
    public class CalculadorDescontos
    {
        public double Calcular(Orcamento orcamento)
        {
            IDesconto descontoPorCincoItens = new DescontoPorCincoItens();
            IDesconto descontoPorMaisDeSeiscentosReais = new DescontoPorMaisDeSeiscentoReais();
            IDesconto semDesconto = new SemDesconto();

            //Ligando Descontos 
            descontoPorCincoItens.ProximoDesconto = descontoPorMaisDeSeiscentosReais;
            descontoPorMaisDeSeiscentosReais.ProximoDesconto = semDesconto;

            return descontoPorCincoItens.Descontar(orcamento);
        }
    }
}

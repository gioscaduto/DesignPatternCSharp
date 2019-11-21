
namespace Visitor
{
    public interface IExpressao
    {
        int Avaliar();
        void Aceitar(IVisitor impressora);
    }
}

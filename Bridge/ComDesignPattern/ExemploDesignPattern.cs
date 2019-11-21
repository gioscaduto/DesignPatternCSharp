
namespace Bridge.ComDesignPattern
{
    /* Bridge
     * Para Um Novo Tipo de Mensagem com formatacao Diferente, basta criar apenas UMA nova classe herdando da Interface IMensagem
     * Para Uma Nova Forma de Envio, basta criar apenas UMA nova classe herdando da Interface IEnviador
     * Separada a responsabilidade das 2 Hierarquias de Classes (Mensagem e Enviador), desta maneira e dimunuido o numero de classes no projeto
     * O Nome Bridge e devido a ponte que e criada entre a Interface IMensagem e IEnviador
     */
    public class ExemploDesignPattern
    {
        public static void Executar()
        {
            IMensagem mensagem = new MensagemAdministrativa("João");

            IEnviador enviador = new EnviaPorEmail();
            mensagem.Enviador = enviador;
            mensagem.Enviar();

            enviador = new EnviaPorSMS();
            mensagem.Enviador = enviador;
            mensagem.Enviar();
        }
    }
}

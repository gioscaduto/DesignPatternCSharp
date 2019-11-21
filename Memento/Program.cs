using System;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Design Pattern Memento
             * Utilizado para salvar o Estado de um Objeto
             * Util para recuperar o Estado de um Objeto em um certo momento por exemplo.
             */

            Historico historico = new Historico();

            Contrato contrato = new Contrato(DateTime.Now, "Joao", TipoContrato.Novo);
            historico.Adicionar(contrato.SalvarEstado()); // TIPO CONTRATO = NOVO
            
            contrato.Avancar(); // TIPO CONTRATO = ANDAMENTO
            historico.Adicionar(contrato.SalvarEstado());

            contrato.Avancar(); // TIPO CONTRATO = ACERTADO
            historico.Adicionar(contrato.SalvarEstado());

            contrato.Restaurar(historico.Obter(1)); // TIPO CONTRATO = ANDAMENTO * RESTAURANDO ESTADO
            historico.Adicionar(contrato.SalvarEstado());

            contrato.Avancar(); // TIPO CONTRATO = ACERTADO
            historico.Adicionar(contrato.SalvarEstado());

            contrato.Avancar(); // TIPO CONTRATO = CONCLUIDO
            historico.Adicionar(contrato.SalvarEstado());

            Console.WriteLine("Historico de Estados");

            Estado estado;
            for (int i = 0; i < historico.QtdEstados; i++)
            {
                estado = historico.Obter(i);

                Console.WriteLine();
                Console.WriteLine($"Data de Alteracao: {estado.DtAlteracao.ToString("dd/MM/yyyy HH:mm:ss:fff")}");
                Console.WriteLine($"Data do Contrato: {estado.Contrato.Dt.ToString("dd/MM/yyyy HH:mm:ss:fff")}");
                Console.WriteLine($"Cliente: {estado.Contrato.Cliente}");
                Console.WriteLine($"Tipo: {estado.Contrato.Tipo}");
            }

            Console.ReadKey();
        }
    }
}

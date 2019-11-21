using static System.Console;

namespace Strategy.SemDesignPattern
{
    public class CalculadorImpostos
    {
        public void RealizaCalculo(Orcamento orcamento, string imposto)
        {
            if ("ICMS".Equals(imposto))
            {
                double icms = orcamento.Valor * 0.05;
                WriteLine(icms);
            }
            else if ("ISS".Equals(imposto))
            {
                double iss = orcamento.Valor * 0.14;
                WriteLine(iss);
            }
            else if("IPI".Equals(imposto))
            {
                double iss = orcamento.Valor * 0.12;
                WriteLine(iss);
            }
            /* else if Outro Imposto
             * else if Outro Imposto 
             * else if Outro Imposto 
             * else if Outro Imposto 
              
             Problema: Classe nao coesa com Muitas Verificacoes e Responsabilidades*/
        }
    }
}

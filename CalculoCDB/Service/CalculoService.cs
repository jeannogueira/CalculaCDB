using CalculoCDB.Domain;
using CalculoCDB.Interfaces;

namespace CalculoCDB.Service
{
    public class CalculoService : ICalculoService
    {

        public Resultado CalculaCDB (Calculo calculo)
        {
            var valorIn = calculo.ValorInicial;
            var inicial = calculo.ValorInicial;
            for (int i = 0; i < calculo.Prazo; i++) 
            {
                calculo.ValorFinal = inicial * (1 + ( 0.009 * 1.08));

                inicial = calculo.ValorFinal;
            }
            var resultado = CalculaImposto(Math.Round(calculo.ValorFinal, 2), valorIn, calculo.Prazo);
            
            return resultado;
        }

        public Resultado CalculaImposto(double valorTotal, double valorIn, double prazo) 
        {
            var resultado = new Resultado
            {
                Bruto = valorTotal
            };
            double ganhosBruto = valorTotal - valorIn;
            double ganhosLiquido = 0;
            switch (prazo)
            {
                case  <= 6:
                    ganhosLiquido = ganhosBruto - (ganhosBruto * 0.225);
                    resultado.Liquido = Math.Round((valorIn + ganhosLiquido), 2);      
                    break;
                case <= 12:
                    ganhosLiquido = ganhosBruto - (ganhosBruto * 0.2);
                    resultado.Liquido = Math.Round((valorIn + ganhosLiquido), 2);
                    break;
                case <= 24:
                    ganhosLiquido = ganhosBruto - (ganhosBruto * 0.175);
                    resultado.Liquido = Math.Round((valorIn + ganhosLiquido), 2);
                    break;
                case > 24:
                    ganhosLiquido = ganhosBruto - (ganhosBruto * 0.15);
                    resultado.Liquido = Math.Round((valorIn + ganhosLiquido), 2);
                    break;
            }
            return resultado;
        }
    }
}

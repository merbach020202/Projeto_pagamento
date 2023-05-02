using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduCredito
{
    public class Crédito
    {
        public int numParcelas;

        public float valorCompra;

        public float juros()
        {
            if (numParcelas > 0 && numParcelas <= 6)
            {
                float valor = valorCompra / numParcelas;
                float ValorJuros = (valor * 1.05F);
                Console.WriteLine(@$"
Parcelas por mes: {ValorJuros}");
            }
            else if (numParcelas > 6 && numParcelas <= 12)
            {
                float valor = valorCompra / numParcelas;
                float ValorJuros = (valor * 1.08F);
                Console.WriteLine(@$"
Quantidade de parcelas por mês: {numParcelas}    
Parcelas por mes: {ValorJuros}");
            }

            return 0;
        }
    }
}
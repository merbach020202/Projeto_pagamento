using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_pagamento
{
    public class Credito
    {
        public int juros()
        {
            int parcelamento = 0;
            do
            {
                if (parcelamento >= 6)
                {
                    ValorTotal = (ValorCompra * 0.05) + ValorCompra;
                }
                else if (parcelamento > 6 && parcelamento <= 12)
                {
                    ValorTotal = (ValorCompra * 0.08) + ValorCompra;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Digite novamente o numero de parcelas realizado!");
                    Console.ResetColor();
                }
            } while (QtdParcelas == 0 || QtdParcelas > 12);
                

                return 0;
        }
    }
}
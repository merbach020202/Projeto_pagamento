using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_pagamento
{
    public class Boleto
    {
         public void PagamentoBoleto(double valorCompra)
        {
            double valorBoleto = valorCompra * 0.88;
            string codigoBarras = GerarCodigoBarras();
            Console.WriteLine("Valor a ser pago: R$ " + valorBoleto.ToString("F2"));
            Console.WriteLine("Código de barras: " + codigoBarras);
        }


        public string GerarCodigoBarras()
        {
            Random rnd = new Random();
            string codigoBarras = "";

            for (int i = 0; i < 48; i++)
            {
                codigoBarras += rnd.Next(0, 10);
            }

            return codigoBarras;
        }

        //  public string GerarCodigoBarras()
        // {
        //     Random rnd = new Random();

        //     string codigoBarras = rnd.Next(3000000000000000000);            

        //     return codigoBarras;
        // }

    }
}
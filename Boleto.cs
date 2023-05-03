using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_pagamento
{
    public class Boleto : Pagamento
    {

        double Valor;
        DateTime dataVencimento;

        public void PagamentoBoleto()
        {
            Console.Write($"\nDigite o valor da compra: ");
            Valor = double.Parse(Console.ReadLine());
             while (Valor < 0)
            {
                Console.Write(@$"
Digite o valor correto da compra: ");
                Valor = float.Parse(Console.ReadLine());
            }

            double valorBoleto = Valor * 0.88;
            string codigoBarras = GerarCodigoBarras();

            Console.WriteLine("\nValor a ser pago com desconto: R$ " + valorBoleto.ToString("F2"));
            Console.WriteLine("\nCódigo de barras: " + codigoBarras);

            // Adiciona 3 dias à data de vencimento
            DateTime dataAtual = DateTime.Now.Date;
            TimeSpan diasParaPagar = dataVencimento.Date - dataAtual;
            DateTime dataLimite = dataAtual.AddDays(Math.Max(3, diasParaPagar.Days));
            Console.WriteLine("\nData limite para pagamento: " + dataLimite.ToString("dd/MM/yyyy"));
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
    }
}
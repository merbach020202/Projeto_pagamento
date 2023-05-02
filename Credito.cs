using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Projeto_pagamento;

namespace EduCredito
{
    public class Credito : Cartao
    {
        public int numParcelas;

        public float valorCompra;

        public float valorTotal;

        double limite = 5000;


        public override void Pagar()
        {
            BandeiraCartao bandeiraCartao = new BandeiraCartao();

            Console.WriteLine(@$"
           ---------------------------------------
          | quantas vezezes deseja parcelar?     |
          |                                      |
          |  juros de 5% até 6 parcelas          |
          |  juros de 8% de 7 a 12 parcelas      |
          |  (em até 12x)                        |
          ---------------------------------------  
            ");
            Console.WriteLine($"Digite o número do seu cartão: ");
            string bandeira = Console.ReadLine();

            while (bandeira.Length != 16)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(@$"
Número do cartão incorreto, digite novamente: ");
Console.ResetColor();
                bandeira = Console.ReadLine();
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@$"
Cartão selecionado: 
{bandeiraCartao.IdentificarBandeira(bandeira)}");
Console.ResetColor();


            while (numParcelas <= 0 || numParcelas > 12)
            {
                Console.WriteLine(@$"
Digite a quantidade de parcelas a serem efetuadas: ");
                numParcelas = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(@$"
Digite o valor da compra: ");
            valorCompra = float.Parse(Console.ReadLine());

            if (valorCompra > limite)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Limite estourado!");
                Console.ResetColor();
                Environment.Exit(0);
            }

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
Valor a ser pago por mês: {Math.Round(ValorJuros, 2).ToString("C", new CultureInfo("pt-BR"))}");
            }

            // float valorFinal = (  )
        }

        // public override void Pagar()
        // {
        //     throw new NotImplementedException();
        // }
    }
}



public class BandeiraCartao : Cartao
{
    public void Main(string[] args)
    {
        // Exemplos de números de cartão para teste
        string[] cartoes = {
            "4111111111111111", // Visa
            "5500000000000004", // Mastercard
            "340000000000009", // American Express
            "6011000000000004", // Discover
            "3530111333300000", // JCB
            "6331101999990016" // Switch/Solo (agora Maestro)
        };

        foreach (string cartao in cartoes)
        {
            string bandeira = IdentificarBandeira(cartao);
            Console.WriteLine("{0} -> {1}", cartao, bandeira);
        }
    }

    public string IdentificarBandeira(string numeroCartao)
    {
        // Expressões regulares para cada bandeira
        Regex visaRegex = new Regex(@"^4[0-9]{12}(?:[0-9]{3})?$");
        Regex mastercardRegex = new Regex(@"^5[1-5][0-9]{14}$");
        Regex amexRegex = new Regex(@"^3[47][0-9]{13}$");
        Regex discoverRegex = new Regex(@"^6(?:011|5[0-9]{2})[0-9]{12}$");
        Regex jcbRegex = new Regex(@"^(?:2131|1800|35\d{3})\d{11}$");
        Regex maestroRegex = new Regex(@"^(?:5[0678]\d\d|6304|6390|67\d\d)\d{8,15}$");

        // Identificar a bandeira com base na expressão regular correspondente
        if (visaRegex.IsMatch(numeroCartao))
        {
            return "Visa";
        }
        else if (mastercardRegex.IsMatch(numeroCartao))
        {
            return "Mastercard";
        }
        else if (amexRegex.IsMatch(numeroCartao))
        {
            return "American Express";
        }
        else if (discoverRegex.IsMatch(numeroCartao))
        {
            return "Discover";
        }
        else if (jcbRegex.IsMatch(numeroCartao))
        {
            return "JCB";
        }
        else if (maestroRegex.IsMatch(numeroCartao))
        {
            return "Maestro";
        }
        else
        {
            return "Bandeira não identificada";
        }
    }

    internal void IdentificarBandeira()
    {
        throw new NotImplementedException();
    }

    public override void Pagar()
    {
        throw new NotImplementedException();
    }
}








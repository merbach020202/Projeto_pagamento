using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_pagamento
{
    public abstract class Cartao : Pagamento
    {

        public string numeroCartao;

        public string bandeira;

        public string cvv;

        private int Saldo;

        public abstract void Pagar();

        public string salvarCartao()
        {
            titular();
            
            Console.WriteLine($"Digite o número do cartão: ");
            numeroCartao = Console.ReadLine();
            
            Console.WriteLine($"Digite a bandeira do cartao: ");
            bandeira = Console.ReadLine();
            
            Console.WriteLine($"Digite o cvv do cartão: ");
            cvv = Console.ReadLine();
            
            return "";
        }
    }
}

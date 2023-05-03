using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_pagamento
{
    public abstract class Cartao 
    {


        public string titular;

        public string numeroCartao;

        public string bandeira;

        public string cvv;

        private int Saldo;

        public abstract void Pagar();

        public string salvarCartao()
        {
            Console.WriteLine($"Digite o nome do titular: ");
            titular = Console.ReadLine();
            
            Console.WriteLine($"Digite o número do cartão: ");
            numeroCartao = Console.ReadLine();
            
            Console.WriteLine($"Digite a bandeira do cartao: ");
            bandeira = Console.ReadLine();
            
            Console.WriteLine($"Digite o nome do titular: ");
            cvv = Console.ReadLine();
            
            return "";
        }

    }

    
}
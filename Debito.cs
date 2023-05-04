using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_pagamento.ClassDebito
{
    public class Debito : Cartao
    {
        public float Saldo { get; private set; }

        public override void Pagar()
        {
            Saldo = 2000;

            Console.Write(@$"
Digite o valor da compra: ");
            float  Valor = float.Parse(Console.ReadLine());
            
            if (Valor <= Saldo)
            {
                Console.WriteLine(@$"
O pagamento de R$ {Valor} foi realizado!");
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Saldo insuficiente!");
                Console.ResetColor();
            }
            Console.WriteLine(@$"
Aperte enter para sair!"
);
            Console.ReadKey();
        }
    }
}



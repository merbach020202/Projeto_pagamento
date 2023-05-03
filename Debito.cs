using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_pagamento.ClassDebito
{
    public class Debito : Cartao
    {
        private float Saldo;
        
        public void PagamentoDebito()
        {
            Saldo = 1000;

            if(Valor <= Saldo)
            {
                Console.WriteLine($"O pagamento de R$ {Valor} foi realizado");
            }

            else
            {
                 Console.WriteLine($"Saldo insuficiente");
             }
         }

        public override void Pagar()
        {
            throw new NotImplementedException();
        }
    }
}
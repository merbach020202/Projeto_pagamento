using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_pagamento
{
    public class Pagamento //Classe pagamento
    {
        public string titular()
        {
            Console.WriteLine($"Digite o nome do titular: ");
            string titular = Console.ReadLine();

            return "";
        }
        
        public float Valor { get; set; } // propriedade valor

        public DateTime Data { get; private set; } //propriedade data

        public void GeraDataPagamento()
        {
            this.Data = DateTime.Now;
        }
    }
}

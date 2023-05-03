using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_pagamento
{
    public class Pagamento //Classe pagamento
    {
        public DateTime Data { get; private set; } = DateTime.Now.Date; //propriedade data
        public float Valor { get; set; } // propriedade valor

        public string Cancelar()
        {
            return "Operacao cancelada";          
        }        
    }
}

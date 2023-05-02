using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_pagamento
{
    public class Pagamento //Classe pagamento
    {


        public float Valor { get; set; } // propriedade valor
       

        public DateTime Data { get; private set; } //propriedade data



        public string Cancelar()  // metodo


        {

            return "Cancelado com sucesso";



        }

        public void GeraDataPagamento()
        {
            this.Data = DateTime.Now;
        }








    }
}
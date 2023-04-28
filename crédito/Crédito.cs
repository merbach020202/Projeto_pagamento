using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crédito
{
    public class Créditos
    {
   public int parcela()
        {
            Console.WriteLine(@$"
           ---------------------------------------
          | quantas vezezes deseja parcelar?     |
          |                                      |
          |  juros de 5% até 6 parcelas          |
          |  juros de 8% de 7 a 12 parcelas      |
          |  (em até 12x)                        |
          ---------------------------------------  
            ");
        
            int numParcela = int.Parse (Console.ReadLine());
              return numParcela;                
        }
    
   
    
    
        
    }
}
using EduCredito;
Crédito classe = new Crédito();

Console.WriteLine(@$"
           ---------------------------------------
          | quantas vezezes deseja parcelar?     |
          |                                      |
          |  juros de 5% até 6 parcelas          |
          |  juros de 8% de 7 a 12 parcelas      |
          |  (em até 12x)                        |
          ---------------------------------------  
            ");



while (classe.numParcelas <= 0 || classe.numParcelas > 12)
{
    Console.WriteLine(@$"
Digite a quantidade de parcelas a serem efetuadas: ");
    classe.numParcelas = int.Parse(Console.ReadLine());
}

Console.WriteLine($"Digite o valor da compra: ");
classe.valorCompra = float.Parse(Console.ReadLine());


classe.juros();

// if (numParcelas > 0 && numParcelas <= 6)
// {
//     float valor = valorCompra / numParcelas;
//     float ValorJuros = (valor * 1.05F);
//     Console.WriteLine(@$"
// Parcelas por mes: {ValorJuros}");
// }
// else if (numParcelas > 6 && numParcelas <= 12)
// {
//     float valor = valorCompra / numParcelas;
//     float ValorJuros = (valor * 1.08F);
//     Console.WriteLine(@$"
// Quantidade de parcelas por mês: {numParcelas}    
// Parcelas por mes: {ValorJuros}");
// }

//feito



using EduCredito;
Crédito classe = new Crédito();

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

Console.WriteLine(@$"
Cartão selecionado: 
{bandeiraCartao.IdentificarBandeira(bandeira)}");


while (classe.numParcelas <= 0 || classe.numParcelas > 12)
{
    Console.WriteLine(@$"
Digite a quantidade de parcelas a serem efetuadas: ");
    classe.numParcelas = int.Parse(Console.ReadLine());
}

Console.WriteLine(@$"
Digite o valor da compra: ");
classe.valorCompra = float.Parse(Console.ReadLine());


classe.juros();








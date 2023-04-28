string menu;

Console.WriteLine($"Bem-Vindo");

do
{
    Console.WriteLine($"Informe o valor total da compra");
    float valorTotal = float.Parse(Console.ReadLine());
    do
    {
        Console.WriteLine(@$"
        -----------------------------------------
        |           MENU DE PAGAMENTO           |
        | 4 - pagamento em boleto               |
        | 3 - pagamento em cartão de crédito    |
        | 2 - pagamento em cartão de débito     |
        | 1 - cancelar operação                 |
        | 0 - sair do sistema                   |
        -----------------------------------------
        ");
        Console.WriteLine($"Escolha uma opção");
        menu = Console.ReadLine();
        switch (menu)
        {
            case "0":
                Console.WriteLine($"FIM");
                break;
            case "1":
                Console.WriteLine($"Operação cancelada");
                break;
            case "2":
                Console.WriteLine($"Você escolheu pagamento em débito");
                break;
            case "3":
                Console.WriteLine($"Você escolheu pagamento em crédito");
                break;
            case "4":
                Console.WriteLine($"Você escolheu pagamento em boleto");
                break;
            default:
                Console.WriteLine($"Selecione uma opção válida");
                break;
        }
    }  while (menu != "0" && menu != "1");
} while (menu != "0");
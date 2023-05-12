using EduCredito;
using Projeto_pagamento;
using Projeto_pagamento.ClassDebito;


Credito credito = new Credito();
Boleto boleto = new Boleto();
Debito debito = new Debito();
Beep beep = new Beep();

static void BarraCarregamento(string texto, int quantidadePontinhos, int tempo)
{

    Console.Write(texto);

    for (int i = 0; i < quantidadePontinhos; i++)
    {
        Console.Write($".");
        Thread.Sleep(tempo);
    }


}


// ========
string menu;

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Bem-Vindo");
Console.ResetColor();

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
            Console.ForegroundColor = ConsoleColor.Blue;
            BarraCarregamento(@"
Carregando", 8, 400
);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@$"

FIM!"
);
            Console.ResetColor();
            beep.PlayMarioMusic();
            break;

        case "1":
            Console.ForegroundColor = ConsoleColor.Blue;
            BarraCarregamento(@"
Carregando", 8, 400
);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@$"

Operação cancelada!
");
            Console.ResetColor();
            Console.WriteLine($"Aperte enter para continuar!");
            Console.ReadKey();
            Console.Clear();
            break;

        case "2":
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nVocê escolheu pagamento em débito!"
            );
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            BarraCarregamento(@"
Carregando", 8, 400
);
            Console.ResetColor();
            Console.Clear();
            debito.Pagar();
            Console.Clear();
            break;

        case "3":
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nVocê escolheu pagamento em crédito!"
            );
            Console.ForegroundColor = ConsoleColor.Blue;
            BarraCarregamento(@"
Carregando", 8, 400
);
            Console.ResetColor();
            Console.Clear();
            credito.Pagar();
            break;

        case "4":
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nVocê escolheu pagamento em boleto!"
            );
            Console.ForegroundColor = ConsoleColor.Blue;
            BarraCarregamento(@"
Carregando", 8, 400
);
            Console.ResetColor();
            Console.Clear();
            boleto.PagamentoBoleto();
            boleto.GerarCodigoBarras();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nAperte enter para continuar!");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
            break;

        default:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Selecione uma opção válida!");
            Console.ResetColor();
            Console.Clear();
            break;
    }


} while (menu != "0");



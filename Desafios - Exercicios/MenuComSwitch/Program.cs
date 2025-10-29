int opcao; //opção inválida

do
{
    Console.Clear(); //limpa o console
    Console.WriteLine($"---------------------------------------------------------------");
    Console.WriteLine($"                           Bem VIndo                           ");
    Console.WriteLine($"                              Ao                               ");
    Console.WriteLine($"                        Jarareca Food                          ");
    Console.WriteLine($"---------------------------------------------------------------");
    Console.WriteLine();
    Console.WriteLine();

    Console.WriteLine($"Escolha uma opção no menu abaixo:");
    Console.WriteLine();
    Console.WriteLine($"    1) Hot Holl");
    Console.WriteLine($"    2) Temaki");
    Console.WriteLine($"    3) Sashimi");
    Console.WriteLine($"    4) Yakisoba");
    Console.WriteLine($"    5) Guioza");
    Console.WriteLine($"    6) Shimeji");
    Console.WriteLine($"    0) Sair");
    Console.Write($"Opção: "); // exibe o texto sem pular linha
    opcao = int.Parse(Console.ReadLine());


    switch (opcao)
    {
        case 0:
            Console.WriteLine($"Saindo...");
            break;

        case 1:
            HottRoll();
            break;

        case 2:
            Temaki();
            break;

        case 3:
            Sashimi();
            break;

        case 4:
            Yakisoba();
            break;

        case 5:
            Guioza();
            break;

        case 6:
            Shimeji();
            break;

        default:
            Console.WriteLine($"Opção inválida");
            break;
    }

    Console.WriteLine($"Digite <Enter> para continuar...");
    Console.ReadLine(); //só pra parar o programa aqui
} while (opcao != 0);


void HottRoll()
{
    //a lógica da funçào 
    Console.WriteLine($"Boa escolha, vamos preparar seu Hot Holl com carinho");
}

void Temaki()
{
    Console.WriteLine($"Boa escolha, vamos preparar seu Temaki com carinho");
}

void Sashimi()
{
    //a lógica da funçào 
    Console.WriteLine($"Boa escolha, vamos preparar seu Sashimi com carinho");
}

void Yakisoba()
{
    //a lógica da funçào 
    Console.WriteLine($"Boa escolha, vamos preparar seu Yakisoba com carinho");
}

void Guioza()
{
    //a lógica da funçào 
    Console.WriteLine($"Boa escolha, vamos preparar seu Guioza com carinho");
}

void Shimeji()
{
    //a lógica da funçào 
    Console.WriteLine($"Boa escolha, vamos preparar seu Shimeji com carinho");
}

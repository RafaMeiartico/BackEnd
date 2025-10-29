string[] nome = new string[10];
float[] saldos = new float[10];
int totalClientes = 0;

int opcao;

do
{
    Console.Clear();
    Console.WriteLine($"=== SISTEMA BANCÁRIO SIMPLES ===");
    Console.WriteLine($"1) Cadastrar Cliente");
    Console.WriteLine($"2) Depositar");
    Console.WriteLine($"3) Sacar");
    Console.WriteLine($"4) Transferir");
    Console.WriteLine($"5) Listar Clientes");
    Console.WriteLine($"0) Sair");
    Console.Write($" Escolha uma opção: ");
    
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {

        case 0:
       
        Console.WriteLine($"encerrando o programa...");
        
            break;

        case 1:
            CadastrarCliente();
            break;

        case 2:
            Depositar();
            break;

        case 3:
            Sacar();
            break;

        case 4:
            Transferencia();
            break;

        case 5:
            ListarClientes();
            break;

        default:
        Console.WriteLine($"Opção inválida, tente novamente");
        
            break;
    }

    Console.WriteLine($"Precione <Enter> para continuar...");
    Console.ReadLine();

} while (opcao != 0);

void CadastrarCliente()
{
    if (totalClientes >= 10)
    {
        Console.WriteLine($"Limite clientes atingido");
        return;
    }

    Console.WriteLine("Digite o nome do cliente");
    nome[totalClientes] = Console.ReadLine();
    saldos[totalClientes] = 0;

    totalClientes++;

    Console.WriteLine($"Cliente cadastrado com êxito!");
}

void Depositar()
{
    Console.WriteLine($"Função depositar em desenvolvimento");
}

void Sacar()
{
    Console.WriteLine($"Função sacar em desenvolvimento");
}

void Transferencia()
{
    Console.WriteLine($"Função tranferencia em desenvolvimento");
}

void ListarClientes()
{
    Console.WriteLine($"== Lista de Clientes ==");

    for (int i = 0; i < totalClientes; i++)
    {
        Console.WriteLine($"{i + 1}- {nome[i]} | Saldo: R$: {saldos[i]}");
        Console.WriteLine();

    }
}
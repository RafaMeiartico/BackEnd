string[] nomes = new string[3];
int[] idades = new int[3];
int totalAlunos = 0;
int opcao = -1;

do
{
    Console.Clear();
    Console.WriteLine($"=======Aplicativo Sala de Aula========");
    Console.WriteLine($"1) Listar aluno");
    Console.WriteLine($"2) Cadastrar alunos");
    Console.WriteLine($"0) Sair");
    Console.Write($"Escolha sua opção: ");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 0:
            Console.WriteLine($"Encerrando...");
            break;
        case 1:
            ListarAluno();
            break;
        case 2:
            CadastrarAluno();
            break;
        default:
            Console.WriteLine($"Opção inválida");

            break;
    }
    Console.WriteLine($"Precione <Enter> para continuar...");
    Console.ReadLine();

} while (opcao != 0);


void ListarAluno()
{
    Console.WriteLine($"=== Listagem de aluno ===");


    for (int i = 0; i < totalAlunos; i++)
    {
        Console.WriteLine($"Nome: {nomes[i]}, {idades[i]}");

        Console.WriteLine();

    }

}

void CadastrarAluno()
{
    Console.WriteLine($"=== Cadastro de aluno ===");

    if (totalAlunos >= 3)
    {
        Console.WriteLine($"Limite de vagas atingido");
        return; //para a execução da função - retorna a função
    }

    Console.WriteLine("Digite o nome do aluno");
    nomes[totalAlunos] = Console.ReadLine();

    Console.WriteLine($"Digite a idade de {nomes[totalAlunos]}");
    idades[totalAlunos] = int.Parse(Console.ReadLine());
    totalAlunos++; //atualiza a variável de controle de alunos
    Console.WriteLine($"Aluno cadastrado com sucesso!");
}
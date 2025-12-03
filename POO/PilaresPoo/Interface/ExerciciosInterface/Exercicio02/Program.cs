using Exercicio02;

//criar uma lista para faturas
List<IImprimivel> documentos = new List<IImprimivel>();



//Criar um menu

int opcao;

do
{
    Console.Clear();
    Console.Write($@"
   Menu de opções:
1) Cadastrar Fatura
2) Cadastrar Relatório
3) Cadastrar Contrato
4) Listar Faturas
5) Listar Relatórios
6) Listar Contratos
0) Sair
  Escolha a opção: ");
    opcao = int.Parse(Console.ReadLine());

    //criar um switch case para as opções do menu


    switch (opcao)
    {
        case 1:
            CadastrarFaturas();
            break;
        case 2:
            CadastrarRelatorios();
            break;
        case 3:
            CadastrarContratos();
            break;
        case 4:
            ListarFaturas();
            break;
        case 5:
            ListarRelatorios();
            break;
        case 6:
            ListarContratos();
            break;
        case 0:
            Console.WriteLine($"Saindo...");
            break;
        default:
            Console.WriteLine($"Opção inválida, tente novamente");
            break;
    }

    Console.WriteLine($"Pressione <Enter para continuar");
    Console.ReadLine();

} while (opcao != 0);

//Funções Auxiliares

void CadastrarFaturas()
{
    Console.WriteLine($"Digite o nome do Cliente Devedor");
    string dev = Console.ReadLine();
    Console.WriteLine($"Digite o nome da empresa");
    string empresa = Console.ReadLine();
    Console.WriteLine($"Digite o valor da dívida");
    float valor = float.Parse(Console.ReadLine());
    Console.WriteLine($"Dias de atraso da fatura?");
    int qtdDiasAtraso = int.Parse(Console.ReadLine());

    Fatura fat = new Fatura(dev, empresa, valor, qtdDiasAtraso);
    documentos.Add(fat);

    Console.WriteLine($"Fatura Cadastrada com sucesso!");

}

void CadastrarRelatorios()
{
    Console.WriteLine($"Digite o nome do Responsável pelo Relatório.");
    string Nome = Console.ReadLine();
    Console.WriteLine($"Digite o texto do Relatório.");
    string Texto = Console.ReadLine();

    Relatorio relatorio = new Relatorio(Nome, Texto);
    documentos.Add(relatorio);

    Console.WriteLine($"Relatório Cadastrada com sucesso!");
}

void CadastrarContratos()
{
    Console.WriteLine($"Digite o Nome do responsável pelo Contrato");
    string Nome = Console.ReadLine();
    Console.WriteLine($"Digite o texto do Contrato");
    string Texto = Console.ReadLine();

    Contrato contrato = new Contrato(Nome, Texto);
    documentos.Add(contrato);

    Console.WriteLine($"Contrato Cadastrado com sucesso!");

}

void ListarContratos()
{
    Console.WriteLine($"Listando Contrato:");

    foreach (var item in documentos)
    {
        if (item is Contrato)
        {
            item.Imprimir();
        }
    }
}

void ListarFaturas()
{
    Console.WriteLine($"Listando Faturas:");

    foreach (var item in documentos)
    {
        if (item is Fatura)
        {
            item.Imprimir();
        }
    }
}

void ListarRelatorios()
{
    Console.WriteLine($"Listando Relatórios:");

    foreach (var item in documentos)
    {
        if (item is Relatorio)
        {
            item.Imprimir();
        }
    }
}



//para cada opção, vamos chamar uma função auxiliar




















































































// //cria o objeto de cada classe e adiciona nas listas
// Fatura fatRafa = new Fatura();
// documentos.Add(fatRafa);

// Fatura fatBia = new Fatura();
// documentos.Add(fatBia);

// Relatorio relRafa = new Relatorio();
// documentos.Add(relRafa);

// Contrato ConRafa = new Contrato();
// documentos.Add(ConRafa);

// //Listar os dados da fatura

// Console.WriteLine($"FATURAS:");
// foreach (var fatura in documentos)
// {
//     if (fatura is Fatura)
//     {//se for fatura
//         fatura.Imprimir();
//     }
// }


// Console.WriteLine($"CONTRATOS:");
// foreach (var item in documentos)
// {
//     if(item is Contrato)
//     {
//     item.Imprimir(); 
//     }
// }

// Console.WriteLine($"RELÁTORIOS:");
// foreach (var item in documentos)
// {
//     if(item is Relatorio)
//     {
//         item.Imprimir(); 
//     }
// }
using Calculadora;
Calculator calc = new Calculator();
int opcao;

do
{
    Console.Clear();
    Console.WriteLine($"========================");
    Console.WriteLine($"== Calculadora Simples==");
    Console.WriteLine($@"Menu:
1) Soma
2) Subtrair
3) Multiplicar
4) Dividir
0) Sair");
    Console.WriteLine($"========================");
    Console.Write($"Opção: ");
    opcao = int.Parse(Console.ReadLine());


    //Pede os números ao usuário
    Console.Write($"Digite o primeiro número: ");
    calc.Numero1 = double.Parse(Console.ReadLine());

    Console.Write($"Agora, digite o segundo número: ");
    calc.Numero2 = double.Parse(Console.ReadLine());


    switch (opcao)
    {
        case 0:
            Console.WriteLine($"Saindo...");
            break;

        case 1:
            Console.WriteLine($"Resultado da Soma: {calc.Somar()}");
            Console.WriteLine();
            break;

        case 2:
            Console.WriteLine($"Resultado da Subtração: {calc.Subtrair()}");
            Console.WriteLine();

            break;

        case 3:
            Console.WriteLine($"Resultado da Multiplicação: {calc.Multiplicar()}");
            Console.WriteLine();
            break;

        case 4:
            Console.WriteLine($"Resultado da Divisão: {calc.Dividir()}");
            Console.WriteLine();
            break;

        default:
            Console.WriteLine($"Opção inválida, tente novamente");
            break;
    }
    Console.WriteLine($"Precione <ENTER> para continuar...");
    Console.ReadLine();

} while (opcao != 0);


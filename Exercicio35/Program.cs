int qtdRep,n1, n2, contador = 1;

Console.WriteLine("Digite quantas vezes você deseja que repita.");
qtdRep = int.Parse(Console.ReadLine());

while (contador <= qtdRep)
{
    Console.Write("Digite o primeiro número: ");
    n1 = int.Parse(Console.ReadLine());

    Console.Write("Digite o segundo número: ");
    n2 = int.Parse(Console.ReadLine());

    if (n1 > n2)
    {
        Console.WriteLine($"O maior número é {n1}");
        Console.WriteLine();
    }
    else if (n2 > n1)
    {
        Console.WriteLine($"O maior número é {n2}");
        Console.WriteLine();
    }
    else
    {
        Console.WriteLine("Os números são iguais");
    }

    Console.WriteLine();
    contador++;
}
//Pedir para o usuário digitar 2 numeros em seguida verificar e exibir qual é o maior dos dois números


int n1, n2;

Console.WriteLine("Digite seu primeiro número");
n1 = int.Parse(Console.ReadLine());

Console.WriteLine("Otimo, agora digite seu segundo número");
n2 = int.Parse(Console.ReadLine());

if (n1 > n2)
{
    Console.WriteLine($"O maior número é {n1}");
}
else if (n2 > n1)
{
     Console.WriteLine($"O maior número é {n2}");
}
else
{
    Console.WriteLine($"Os números tem o mesmo valor");
}
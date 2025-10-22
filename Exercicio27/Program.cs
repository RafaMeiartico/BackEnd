int qtdNumero, contador = 1;

Console.WriteLine("Qual a quantidade de números que você deseja digitar?");
qtdNumero = int.Parse(Console.ReadLine());

while (contador <= qtdNumero)
{
    Console.WriteLine($"Digite um número:");
    int numeroDigitado = int.Parse(Console.ReadLine());

    if (numeroDigitado % 2 == 0)
    {
        Console.WriteLine($"O número digitado é par: {numeroDigitado}");
    }
        contador++;
}
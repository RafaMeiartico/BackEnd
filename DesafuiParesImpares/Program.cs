//PERGUNTAR AO USUARIO QUANTOS NUMEROS ELE QUER DIGITAR 
//EXIBIR, SEPARADAMENTE, OS NÚMEROS PARES E OS NÚMEROS IMPARES QUE ELE DIGITAR

int qntNumero = 0;


Console.WriteLine("Olá, digite quantos números você deseja digitar");
qntNumero = int.Parse(Console.ReadLine());
string pares = "Pares: ";
string impares = "Impares: ";

for (int i = 1; i <= qntNumero; i++)
{
    Console.WriteLine($"Qual é o {i}º número?");
    int numeroDigitado = int.Parse(Console.ReadLine());

    if (numeroDigitado % 2 == 0)
    {//é par?
        pares += numeroDigitado.ToString(); //Guarda o numero como texto/string
    }
    else
    {
        impares += numeroDigitado.ToString();
    }
}


Console.Clear();
Console.WriteLine("Resulatados");
Console.WriteLine();
Console.WriteLine($"{pares}");
Console.WriteLine($"{impares}");
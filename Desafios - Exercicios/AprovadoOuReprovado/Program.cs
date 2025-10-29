int frequencia, nota;

Console.WriteLine("Seja bem-vindo(a) ao nosso programa: "); 
Console.WriteLine(); 
Console.WriteLine("Digite a frequência do aluno.");
frequencia = int.Parse(Console.ReadLine()); 

Console.WriteLine("Digite a nota do aluno.");
nota = int.Parse(Console.ReadLine());

if (frequencia >= 75 && nota >= 7)
{
    Console.WriteLine($"Aluno Aprovado");
}
else if (frequencia >= 75 && nota >= 3)
{
    Console.WriteLine($"Aluno em recuperação");
}
else if (frequencia <= 74 && nota <= 10)
{
    Console.WriteLine($"Aluno reprovado por frequência");
}
else
{
    Console.WriteLine($"Aluno reprovado");
}

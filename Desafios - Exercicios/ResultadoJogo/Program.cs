//Desenvolva um programa que recebe do usuário, o placar de um jogo de futebol (os gols de cada time) e informa se o resultado foi um
//empate, se a vitória foi do primeiro time ou do segundo time.


int time1, time2;


Console.WriteLine("Seja bem-vindo(a) ao nosso programa: ");
Console.WriteLine("Digite o placar do primeiro time");
time1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o placar do segundo time");
time2 = int.Parse(Console.ReadLine());


if (time1 > time2)
{
    Console.WriteLine("Vitória do primeiro time");
}
else if (time1 < time2)
{
    Console.WriteLine("Vitória do segundo time");
}
else
{
    Console.WriteLine("Empate.");
}
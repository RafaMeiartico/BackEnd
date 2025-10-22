using System.Runtime.InteropServices;

double salario;
string cargo;

Console.WriteLine("Olá, seja bem-vindo(a). Digite seu cargo");
cargo = Console.ReadLine();

Console.WriteLine("Certo, agora digite seu salário");
salario = double.Parse(Console.ReadLine());

if (cargo == "produção")
{
    Console.WriteLine($"O seu aumento será de 6.5%, ficando {salario * 1.065}");
}
else if (cargo == "administrativo")
{
    Console.WriteLine($"O seu aumento será de 7.5%, ficando {salario * 1.075}");
}
else if (cargo == "diretoria")
{
    Console.WriteLine($"O seu aumento será de 12%, ficando {salario * 1.12}");
}
else
{
    Console.WriteLine("Não existe aumento para esse cargo, reinicie o programa e tente novamente");
}
using System.Globalization;
using ExercicioHeranca;

Funcionario Rafa = new Funcionario();
Gerente Bia = new Gerente();

Rafa.SalarioBase = 100;
Rafa.Nome = "Rafaela";

Bia.SalarioBase = 100;
Bia.Bonus = 200;
Bia.Nome = "Anna Beatriz";

float SalFinalComum = Rafa.CalcularSalario();
float SalFinalGen =Bia.CalcularSalario();

Console.WriteLine($"Salário final do Funcionário : {SalFinalComum}");
Console.WriteLine($"Salário final do Funcionário: {SalFinalGen}");

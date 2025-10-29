//Faça um programa que o usuário informe o salário recebido e o total gasto. Deverá ser exibido na tela “Gastos dentro do orçamento” 
//caso o valor gasto não ultrapasse o valor do salário e “Orçamento estourado” se o valor gasto ultrapassar o valor do salário.

double salario, despesas;


Console.WriteLine("Seja bem-vindo(a) ao nosso programa: ");
Console.WriteLine("Digite o quanto você recebe");
salario = double.Parse(Console.ReadLine());


Console.WriteLine("Perfeito, agora digite suas despesas: ");
despesas = double.Parse(Console.ReadLine());

if (salario > despesas)
{
    Console.WriteLine("Gastos dentro do orçamento");
}
else if (salario < despesas)
{
    Console.WriteLine("Orçamento estourado");
}
else
{
    Console.WriteLine("Despesas e salário iguais.");
}
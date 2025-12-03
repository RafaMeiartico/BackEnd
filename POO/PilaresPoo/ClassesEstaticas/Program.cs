using ClassesEstaticas;

namespace ClassesEstaticas
{
    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine($"Potência de 3²: {Math.Pow(3,2)} ");
            
        }
    }
}























// Console.WriteLine($"Número de PI: {CalculosMatematicos.PI}");
// Console.WriteLine($"Soma de 5 e 10: {CalculosMatematicos.Somar(5, 10)}");
// Console.WriteLine($"Subtração de 5 e 10: {CalculosMatematicos.Subtrair(5, 10)}");
// Console.WriteLine($"Divisão de 5 e 10: {CalculosMatematicos.Dividir(5, 10)}");
// Console.WriteLine($"Multiplicação de 5 e 10: {CalculosMatematicos.Multiplicar(5, 10)}");

// using ClassesEstaticas;

// Console.Clear();
// Console.WriteLine($"Digite o primeiro número:");
// float n1 = float.Parse(Console.ReadLine());

// Console.WriteLine($"Digite o segundo número:");
// float n2 = float.Parse(Console.ReadLine());

// Console.WriteLine($"Maior número:{Math.Max(n1,n2)}");
// Console.WriteLine($"Menor número:{Math.Min(n1,n2)}");


// Console.WriteLine(@"
// Escolha uma das operações:
// 1) Soma
// 2) Subtração
// 3) Multiplicação
// 4) Divisão
// ");
// int opcao = int.Parse(Console.ReadLine());

// switch (opcao)
// {
//     case 1:
//         Console.WriteLine($"Soma: {CalculosMatematicos.Somar(n1, n2)}");
//         break;

//     case 2:
//         Console.WriteLine($" Subtração: {CalculosMatematicos.Subtrair(n1, n2)}");
//         break;

//     case 3:
//         Console.WriteLine($"Multiplicação: {CalculosMatematicos.Multiplicar(n1, n2)}");
//         break;

//     case 4:
//         Console.WriteLine($"Divisão: {CalculosMatematicos.Dividir(n1, n2)}");
//         break;

//     default:
//         Console.WriteLine($"Não tem essa opção...");
//         break;
// }



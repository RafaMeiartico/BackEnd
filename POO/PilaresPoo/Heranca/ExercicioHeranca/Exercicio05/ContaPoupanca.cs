namespace Exercicio05
{
    public class ContaPoupanca : Conta
    {
        public void CalcularRendimento()
        {
            Console.WriteLine($"Seu saldo rendeu 2%");
            Console.WriteLine($"Saldo Atual: {Saldo * 1,02:F2}");
            Console.WriteLine();
        }
    }
}
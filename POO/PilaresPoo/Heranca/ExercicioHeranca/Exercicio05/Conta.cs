namespace Exercicio05
{
    public class Conta
    {
        public int Numero;
        public double Saldo = 0;
        public int Valor;

        public void Depositar()
        {
            Saldo = +Valor;
            Console.WriteLine($"Deposito Feito com Sucesso!");
            Console.WriteLine($"Saldo anterior: {Saldo - Valor}");
            Console.WriteLine($"Saldo atual: {Saldo}");
            Console.WriteLine();
        }

        public void Sacar()
        {
            Saldo = -Valor;
            Console.WriteLine($"Saque Feito com Sucesso!");
            Console.WriteLine($"Saldo anterior: {Saldo + Valor}");
            Console.WriteLine($"Saldo atual: {Saldo}");
            Console.WriteLine();
        }
    }
}
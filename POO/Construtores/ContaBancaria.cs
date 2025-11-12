namespace Construtores
{
    public class ContaBancaria
    {
        public string Titular;

        public float Saldo;


        public ContaBancaria(string t, float s)
        {
            Titular = t;
            Saldo = s;
        }

        public ContaBancaria(string t)
        {
            Titular = t;
            Saldo = 0;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Titular: {Titular} | Saldo: R$:{Saldo}");
            
        }
    }
}
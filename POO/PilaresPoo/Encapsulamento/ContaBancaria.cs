namespace Encapsulamento
{
    public class ContaBancaria
    {
        private float Saldo;

        //Métodos Gets and Sets

        public ContaBancaria()
        {
            Saldo = 0;
        }
        public ContaBancaria(float SaldoInicial)
        {
            if(SaldoInicial > 0)
            {
                Saldo = SaldoInicial;
            }
            else
            {
                Saldo = 0;
            }
        }

        public void Depositar(float valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine($"Valor inválido.");

            }
            else
            {
                Saldo += valor;
            }
        }

        //Get do saldo
        public float GetSaldo()
        {
            return Saldo;
        }


        public void Sacar(float valor)
        {
            if (valor >= 0 && valor <= Saldo)
            {
                Saldo -= valor;
                Console.WriteLine($"Saldo efetuado com sucesso!");

            }
            else
            {
                Console.WriteLine($"digite um saldo saque válido!");
            }
        }
    }
}
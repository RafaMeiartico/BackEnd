namespace ClasseEObjetos
{
    public class ContaBancaria
    {
        public string Titular = "";

        public float Saldo;


        public void Depositar(float _valorDeposito)
        {
            if (_valorDeposito <= 0)
            {
                Console.WriteLine($"O valor do saldo deve ser maior do que 0. | Saldo Atual: {Saldo:F2}");
                return;
            }
            Saldo += _valorDeposito;
            Console.WriteLine($"Depósito realizado com sucesso. | Saldo Atual: {Saldo:F2}");
        }

        public void Saque(float _valorSaque)
        {
            if (_valorSaque > 0 && _valorSaque <= Saldo)
            {
                Console.WriteLine($"Não foi possivel sacar esse valor, verifique os dados e tente novamente. | Saldo Atual: {Saldo:F2}");
                return;
            }
            Saldo -= _valorSaque;

            Console.WriteLine($"Saque realizado com sucesso. | Saldo Atual: {Saldo:F2}");

        }
    }
}

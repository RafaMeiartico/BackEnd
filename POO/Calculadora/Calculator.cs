namespace Calculadora
{
    public class Calculator
    {
        //Atributos
        public double Numero1;
        public double Numero2;
        public double Resultado;


        //Métodos

        public double Somar()
        {
            Resultado = Numero1 + Numero2;
            return Resultado;
        }
        public double Subtrair()
        {
            Resultado = Numero1 - Numero2;
            return Resultado;
        }
        public double Multiplicar()
        {
            Resultado = Numero1 * Numero2;
            return Resultado;
        }
        public double Dividir()
        {
            if (Numero2 == 0)
            {
                Console.WriteLine($"Não existe divisão por 0");
                return -1;
            }

            Resultado = Numero1 / Numero2;
            return Resultado;
        }
    }
}


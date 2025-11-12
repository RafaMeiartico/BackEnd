namespace Construtores
{
    public class Carro
    {
        public string Marca;

        public string Modelo;

        public int Ano;

        public Carro(string x, string y, int z)
        {
            Marca = x;
            Modelo = y;
            Ano = z;
        }
        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Ano: {Ano}");

        }

    }
}
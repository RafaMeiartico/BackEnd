namespace ExercicioHeranca
{
    public class Carro : Veiculo
    {
        public int NmrPorta;
        public void MostrarInfo()
        {
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Quantidade de portas: {NmrPorta}");
        }
    }
}
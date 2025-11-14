namespace ExercicioHeranca
{
    public class Veiculo
    {
        public string Marca;
        public string Modelo;
        public void MostrarInfo()
        {
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
        }
    }
}
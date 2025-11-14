namespace ExercicioHeranca
{
    public class Moto : Veiculo
    {
        public string Capacete;

        public void MostrarInfo()
        {
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Tipo de capacete: {Capacete}");
        }
    }
}
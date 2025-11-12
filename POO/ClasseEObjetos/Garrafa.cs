namespace ClasseEObjetos
{
    public class Garrafa
    {
        public int Litros;
        public string Cor = "";      
        public string Material = "";

        public void Beber()
        {
            Console.WriteLine($"Glup Glup Glup...");
        }

        public void Abrir()
        {
            Console.WriteLine($"click...");
        }
    }
}
namespace ExerciciosInterface
{
    public class Circulo : IForma
    {
        public double Area;
        public double Raio;



        public void CalcularArea()
        {
            Area = Math.PI * Raio * Raio;
        }

                public void ExibirInfo()
        {
            Console.WriteLine($"A Área do retangulo é {Area}");
            
        }
    }
}
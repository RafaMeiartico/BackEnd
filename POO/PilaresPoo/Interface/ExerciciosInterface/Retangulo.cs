namespace ExerciciosInterface
{
    public class Retangulo : IForma
    {
        public int Altura;
        public int Largura;
        public int Area;

        public void CalcularArea()
        {
            Area = Largura * Altura;
        }

        public void ExibirInfo()
        {
            Console.WriteLine($"A Área do retangulo é {Area}");
            
        }
    }
}
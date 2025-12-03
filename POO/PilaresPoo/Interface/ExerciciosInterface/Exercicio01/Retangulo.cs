namespace Exercicio01
{
    public class Retangulo : IForma
    {
        public float Largura;
        public float Altura;


    public Retangulo(float a, float l)
        {
            Largura = l;
            Altura = a;
        }
        public void CalcularArea()
        {
            float Area = Largura * Altura;
            Console.WriteLine($"Área do retângulo: {Area}");
        }
    }
}
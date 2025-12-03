namespace Exercicio01
{
    public class Circulo : IForma
    {
        public float Raio;
        public float PI = 3.14f;

        public void CalcularArea()
        {
            float Area = (float)Math.PI * Raio * Raio;
            Console.WriteLine($"Área do círculo: {Area}");
        }
    }
}
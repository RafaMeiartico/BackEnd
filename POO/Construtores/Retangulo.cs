namespace Construtores
{
    public class Retangulo
    {
        public int Largura;
        public int Altura;

        public Retangulo(int l, int a)
        {
            Largura = l;
            Altura = a;

            int Area = Largura * Altura; 

            Console.WriteLine($"A área do seu retângulo de largura {Largura} e altura {Altura} é {Area}");
        }
        public Retangulo()
        {
            Largura = 1;
            Altura = 1;

            int Area = Largura * Altura; 

            Console.WriteLine($"A área do seu retângulo de largura {Largura} e altura {Altura} é {Area}");
        }
    }
}
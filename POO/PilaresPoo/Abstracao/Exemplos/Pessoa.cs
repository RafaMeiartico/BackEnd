namespace Exemplos
{
    public class Pessoa : Animal
    {
        public string Nome;
        public int Idade;

        public void Dormir()
        {
            Console.WriteLine($"ZzZzZzZzZ");
            
        }

        public override void FazerSom()
        {
            Console.WriteLine($"Oláaa");  
        }

        public override void Mover()
        {
            Console.WriteLine($"teco teco teco");
            
        }
    }
}
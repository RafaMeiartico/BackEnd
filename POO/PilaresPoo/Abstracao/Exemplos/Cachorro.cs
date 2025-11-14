namespace Exemplos
{
    public class Cachorro : Animal
    {
        public override void FazerSom()
        {
            Console.WriteLine($"Au au au");
            
        }

        public override void Mover()
        {
            Console.WriteLine($"tec tec tec tec");
            
        }
    }
}
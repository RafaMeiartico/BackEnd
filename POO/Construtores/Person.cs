namespace Construtores
{
    public class Person
    {
        public string Nome;

        public int Idade;

        public Person()
        {

        }

        public Person(string n)
        {
            Nome = n;
        }

        public Person(string n, int i)
        {
            Nome = n;
            Idade = i;
        }

                public void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome} | Idade: {Idade}");
            
        }
    }
}
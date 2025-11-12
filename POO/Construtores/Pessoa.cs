namespace Construtores
{

    public class Pessoa
    {
        public string Nome;

        public int Idade;

        //Construtores
        public Pessoa()
        {
            Console.WriteLine($"Objeto Criado");

        }

        public Pessoa(string n, int i)
        {
            Nome = n;
            Idade = i;
        }

        public Pessoa(string n)
        {
            Nome = n;
        }

        public Pessoa(string n, int i, string xpto)
        {
            Nome = n;
            Idade = i;
            Console.WriteLine($"Seu texto é: {xpto}");
        }


        //Método
        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome}");

        }
    }
}
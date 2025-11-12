namespace Construtores
{
    public class Livro
    {
        public string Titulo;
        public string Autor;
        public float Preco;

        public Livro(string t, string a)
        {
            Titulo = t;
            Autor = a;
        }

        public Livro(string t, string a, float p)
        {
            Titulo = t;
            Autor = a;
            Preco = p;
        }

                public void ExibirDados()
        {
            Console.WriteLine($"Livro: {Titulo} | Autor(a): {Autor} |Preço: R$:{Preco:F2}");
            
        }
    }
}
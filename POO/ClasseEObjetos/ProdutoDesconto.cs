namespace ClasseEObjetos
{
    public class ProdutoDesconto
    {
        public string Nome = "";

        public float Preco;



        public void Desconto(float percentual)
        {
           float valorDesconto = Preco * (percentual / 100);
            Preco -= valorDesconto;
            Console.WriteLine($"O preço com o desconto aplicado será de: R$:{valorDesconto}");
        }
    }
}
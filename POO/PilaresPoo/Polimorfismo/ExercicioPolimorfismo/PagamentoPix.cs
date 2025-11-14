namespace ExercicioPolimorfismo
{
    public class PagamentoPix : Pagamento
    {
                //Desconto de 5%
        private float desconto = 5;
        public float ValorCompra;

        public override float CalcularTotal()
        {
            float valorDesconto = ValorCompra / 100 * desconto;
            return ValorCompra = ValorCompra - valorDesconto;
        }
    }
}
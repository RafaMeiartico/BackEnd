namespace Exercicio02
{
    public class Contrato : IImprimivel
    {
        public string NomeContrato;
        public string TextoClausulas;

        public Contrato(string Nome, string Texto)
        {
            NomeContrato = Nome;
            TextoClausulas = Texto;
        }

        public void Imprimir()
        {
            Console.WriteLine($@"
    Nome: {NomeContrato}
    Texto do Contrato: {TextoClausulas}
    ");
            
        }
    }
}



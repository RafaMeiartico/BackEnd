namespace Exercicio02
{
    public class Relatorio : IImprimivel
    {
        public string NomeResponsavel;
        public string TextoRelatorio;

        public Relatorio(string Nome, string Texto)
        {
            NomeResponsavel = Nome;
            TextoRelatorio = Texto;
        }



        public void Imprimir()
        {
            Console.WriteLine($@"
    Responsável pelo Relatório: {NomeResponsavel}
    Texto do Relatório: {TextoRelatorio}
    ");

        }
    }
}
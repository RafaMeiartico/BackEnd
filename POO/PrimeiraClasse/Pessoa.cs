
namespace PrimeiraClasse
{
    public class Pessoa
    {
        public string Nome;

        public int Idade = 0;

        public int Altura;

        public string Nacionalidade;


        public void Introdução()
        {
            Console.WriteLine($"Olá, tudo bem?");
        }
        public void Despedir()
        {
            Console.WriteLine($"Então é isso, tchau! Até breve.");

        }

        public void Envelhecer(int _id = 0)
        {

            if (_id > 0)
            {//adiciona a idade que foi recebida
                Idade += _id;
            }
            else
            {//adiciona apenas 1 ano na idade
                Idade++;
            }
        }
    }
}

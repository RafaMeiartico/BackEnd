namespace Encapsulamento
{
    public class Carro
    {
        //Atributos
        private string Marca;
        private string Modelo;
        private int VelocidadeAtual;

        //Métodos

        public void DefinirMarca(string valor)
        {
            Marca = valor;
        }

        public string ObterMarca()
        {
            return Marca;
        }



        public void DefinirModelo(string valor)
        {
            Modelo = valor;
        }
        public string ObterModelo()
        {
            return Modelo;
        }



        public void ObterVelocidade(int valor)
        {
            VelocidadeAtual = valor;
        }


        //Métodos velocidade do carro
        public void Acelerar(int valor)
        {
            VelocidadeAtual += valor;
        }

        public void Freiar(int valor)
        {

            if (valor > 0)
            {
                VelocidadeAtual -= valor;
            }
            else
            {
                VelocidadeAtual = 0;
                Console.WriteLine($"A velocidadae não pode ser negativa!");
            }
        }
    }
}
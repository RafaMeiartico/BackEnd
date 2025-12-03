namespace Exemplos
{
    public class Moto : IMotor
    {
        //Propriedades
        public string Cor;
        public string Marca;
        public string Modelo;
        public int Ano;

        //Construtores

        public Moto(string c, string m, string md, int a)
        {
            Cor = c;
            Marca = m;
            Modelo = md;
            Ano = a;
        }


        //Métodos
        public void ExibirInfo()
        {
            Console.WriteLine($@"
Informações do Veículo:
    Marca: {Marca}
    Modelo: {Modelo}
    Ano: {Ano}
    Cor: {Cor}
              ");
        }

        public void Acelerar()
        {
            Console.WriteLine($"Acelerando com a motoca...");

        }

        public void Freiar()
        {
            Console.WriteLine($"Freiando com ABS...");
        }
    }
}
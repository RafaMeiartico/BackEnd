namespace Construtores
{
    public class Computador
    {
        public string Marca;
        public int MemoriaRam;
        public int Armazenamento;

        public Computador(string m, int n, int a)
        {
            Marca = m;
            MemoriaRam = n;
            Armazenamento = a;
        }
        public Computador()
        {
            Marca = "Lenovo";
            MemoriaRam = 8;
            Armazenamento = 256;
        }

                        public void ExibirDados()
        {
            Console.WriteLine($"Marca: {Marca} | Memoria Ram: {MemoriaRam} GB |Armazenamento: {Armazenamento}");
            
        }
    }
}
namespace Exemplos
{
    public class ControleRemoto : IControle
    {
        public int NivelVolume = 0;
        public int VolumeMaximo = 30;

        public void Ligar()
        {
            Console.WriteLine($"Ligando a TV...");
        }

        public void Desligar()
        {
            Console.WriteLine($"Desligando a TV...");
            return;
        }

        public void AumentarVolume()
        {
            if (NivelVolume == VolumeMaximo)
            {
                Console.WriteLine($"Volume máximo atingido: {NivelVolume}");
                return;
            }

            NivelVolume++;
            Console.WriteLine($"Volume: {NivelVolume}");
        }

        public void DiminuirVolume()
        {
            if (NivelVolume <= 0)
            {
                Console.WriteLine($"Volume mínimo atingido: {NivelVolume}");
                return;
            }

            NivelVolume--;
            Console.WriteLine($"Volume: {NivelVolume}");
        }

    }
}
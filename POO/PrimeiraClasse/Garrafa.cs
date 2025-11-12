using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeiraClasse
{
    public class Garrafa
    {
        public int Litros;

        public string Cor;
        public string Material;




        public void Beber()
        {
            Console.WriteLine($"Glup Glup Glup...");
        }

        public void Abrir()
        {
            Console.WriteLine($"click...");
        }

    }
}
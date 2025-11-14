using ExercicioHeranca;

Carro Ford = new Carro();
Moto BMW = new Moto();

BMW.Marca = "BMW";
BMW.Modelo = "1200";
BMW.Capacete = "Pro tork";

Ford.Marca = "Ford";
Ford.Modelo = "Fuzion";
Ford.NmrPorta = 4;

Ford.MostrarInfo();
BMW.MostrarInfo();

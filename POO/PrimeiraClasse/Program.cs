using PrimeiraClasse;

// Console.WriteLine($"==== PROGRAMA PRIMEIRA CLASSE ====");

// // Carro mclaren = new Carro();
// // mclaren.marca = "McLaren";
// // mclaren.cor = "azul";
// // mclaren.modelo = "750s";
// // mclaren.potencia = 800;

// // Console.WriteLine($"Ligando a {mclaren.marca} {mclaren.cor}");
// // mclaren.Ligar();
// // Console.WriteLine($"Acelerando a {mclaren.marca} de {mclaren.potencia   } cv");
// // mclaren.Acelerar();

// // Pessoa p1 = new Pessoa();
// // p1.nome = "Rafaela";
// // p1.idade = 16;
// // p1.nacionalidade = "Brasileira";

// // p1.introdução();
// // Console.WriteLine($"Eu sou {p1.nome} eu tenho {p1.idade} e eu sou {p1.nacionalidade}");
// // p1.despedir();

// Garrafa Tuppaware = new Garrafa();
// Tuppaware.Cor = "Azul";
// Tuppaware.Litros = 2;
// Tuppaware.Material = "Metal";

// Tuppaware.Beber();
// Tuppaware.Abrir();

// Garrafa Stanley = new Garrafa();
// Stanley.Cor = "Azul goiaba";
// Stanley.Litros = 2;
// Stanley.Material = "Plastico";

// Console.Write($"Abrindo garrafa stanley:");
// Stanley.Abrir();
// Console.Write($"Bebendo água da garrafa stanley:");
// Stanley.Beber();


Pessoa rafa = new Pessoa();
rafa.Nome = "Rafaela Meirelles";
rafa.Altura = 165;

Console.WriteLine($"{rafa.Nome} tem {rafa.Idade} anos");
rafa.Envelhecer(10);
Console.WriteLine($"{rafa.Nome} tem {rafa.Idade} anos");

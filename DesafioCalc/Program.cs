//Pedir para o usuário digitar dois numeros e exibir a soma desses dois números

int numero1, numero2;

Console.WriteLine("Olá, digite seu primeiro número");
numero1 = int.Parse(Console.ReadLine());

Console.WriteLine("Perfeito! Agora digite seu segundo número");
numero2 = int.Parse(Console.ReadLine());

Console.WriteLine($"A soma de {numero1} e {numero2} é {numero1 + numero2}");



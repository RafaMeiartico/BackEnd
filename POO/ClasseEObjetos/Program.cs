using ClasseEObjetos;

// Console.Clear();
// Console.WriteLine($"== Criar sua Garrafa ==");
// Console.WriteLine($);

// Garrafa p1 = new Garrafa();

// Console.Write($"Por favor, digite o seu nome: ");
// string nome = Console.ReadLine();

// Console.Write($"Agora digite o material da sua garrafa: ");
// p1.Material = Console.ReadLine();

// Console.Write($"Certo, agora digite a capacidade da sua garrafa em litros: ");
// p1.Litros = int.Parse(Console.ReadLine());

// Console.Write($"E digite a cor da sua garrafa: ");
// p1.Cor = Console.ReadLine();

// Console.WriteLine($"{nome} sua garrafa é {p1.Cor}, do material {p1.Material} e de {p1.Litros} Litros.");

// Console.Clear();
// Console.WriteLine($"== Agência Bancária ==");
// Console.WriteLine();

// ContaBancaria contaRafa = new ContaBancaria();
// contaRafa.Titular = "Rafa";
// contaRafa.Saldo = 1000.20f;

// contaRafa.Depositar(800);
// contaRafa.Saque(50);

Console.Clear();
Console.WriteLine($"== Produto com Desconto ==");
Console.WriteLine();

ProdutoDesconto descontoRafa = new ProdutoDesconto();
descontoRafa.Nome = "Rafaela";
descontoRafa.Preco = 10f;

descontoRafa.Desconto(20);
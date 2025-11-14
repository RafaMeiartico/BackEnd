using Exemplos;

// Gato Birobinha = new Gato();
// Cachorro Nina = new Cachorro();
// Pessoa Rafa = new Pessoa();

// Rafa.Nome = "Rafaela";
// Rafa.Idade = 16;

// Console.WriteLine($"Nome: {Rafa.Nome}");
// Console.WriteLine($"Idade da {Rafa.Nome}: {Rafa.Idade} anos");

// Console.WriteLine($"Som da {Rafa.Nome}:");
// Rafa.FazerSom();

// Console.WriteLine($"{Rafa.Nome} está se movendo:");
// Rafa.Mover();

// Console.WriteLine($"{Rafa.Nome} foi dormir:");
// Rafa.Dormir();

Console.Clear();

ContaCorrente cc = new ContaCorrente(100);
Console.WriteLine($"======Conta Corrente======");
Console.WriteLine($"Saldo inicial da conta: R${cc.Saldo}");
cc.Depositar(0.5);
Console.WriteLine($"Saldo na conta após o depósito: R${cc.Saldo}");
cc.Sacar(10);
Console.WriteLine($"Saldo na conta após o saque: R${cc.Saldo}");
Console.WriteLine();

ContaPoupanca cp = new ContaPoupanca(100);
Console.WriteLine($"======Conta Poupança======");
Console.WriteLine($"Saldo inicial da conta: R${cp.Saldo}");
cp.Depositar(0.5);
Console.WriteLine($"Saldo na conta após o depósito: R${cp.Saldo}");
cp.Sacar(10);
Console.WriteLine($"Saldo na conta após o saque: R${cp.Saldo}");
Console.WriteLine();
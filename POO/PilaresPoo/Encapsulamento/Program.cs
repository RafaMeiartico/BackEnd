using System.Net.Http.Headers;
using Encapsulamento;

// ContaBancaria contaRafa = new ContaBancaria();
// ContaBancaria contaBia= new ContaBancaria(1500);

// contaRafa.Depositar(300);
// contaRafa.Depositar(20);
// contaRafa.Sacar(100);

// Console.WriteLine($"Saldo atual: {contaRafa.GetSaldo()}");

Carro carroRafa = new Carro();

carroRafa.DefinirMarca("Nissan");
carroRafa.DefinirModelo("Mitsubishi r134");
carroRafa.Acelerar(2);

Console.WriteLine($"Marca do carro: {carroRafa.ObterMarca}");
Console.WriteLine($"Modelo do carro: {carroRafa.ObterModelo}");
Console.WriteLine($"Velocidade atual: {carroRafa.ObterVelocidade} km/h");


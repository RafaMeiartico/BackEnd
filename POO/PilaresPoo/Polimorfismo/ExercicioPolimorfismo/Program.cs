using ExercicioPolimorfismo;

PagamentoPix compraPix = new PagamentoPix();
compraPix.ValorCompra = 15000;

float valorPagar = compraPix.CalcularTotal();
Console.WriteLine($"Produto: Smartphone");
Console.WriteLine($"Preço: {compraPix.ValorCompra}");
Console.WriteLine($"Pagamentos com Desconto: {valorPagar}");


PagamentoCartao compraCartao = new PagamentoCartao();
compraCartao.ValorCompra = 50;

Console.WriteLine($"Produto: Caneca");
Console.WriteLine($"Preço: {compraCartao.ValorCompra}");
Console.WriteLine($"Pagamentos com Desconto: {compraCartao.CalcularTotal()}");
//As maçãs custam R$ 0,30 cada se forem compradas menos do que uma dúzia, e R$ 0,25 se forem compradas pelo menos doze. Escreva um
// programa que leia o número de maçãs compradas, calcule e escreva o valor total da compra.

float qntMaca, totalCompra; 

Console.WriteLine("Seja bem-vindo(a) ao nosso programa: "); 
Console.WriteLine(); 
Console.WriteLine("Digite a quantidade de maças que deseja comprar"); 
qntMaca = float.Parse(Console.ReadLine()); 

if (qntMaca <= 12) 
{ 
    totalCompra = qntMaca * 0.30f; 
    Console.WriteLine($"O valor total da compra: {totalCompra}"); 
} 
else 
{ 
    totalCompra = qntMaca * 0.25f; 
    Console.WriteLine($"O valor total da compra: {totalCompra}"); 
}
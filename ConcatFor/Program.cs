//Perguntar ao usuário quantas letras tem o nome dele
//depois vamos pedir letra a letra de seu nome
//ao final, vamos exibir o nome do usuárioo completo

int qtdLetras = 0;
string nome = "";

Console.WriteLine("Olá usuário! Quantas letras tem seu nome?");
qtdLetras = int.Parse(Console.ReadLine());

for (int i = 1; i <= qtdLetras; i++)
{
    Console.WriteLine($"Qual é a {i}ª letra?");
    nome += Console.ReadLine();
}

Console.WriteLine($"Seu nome é: {nome}");



using Exercicio01;

Console.Clear();
Console.WriteLine($"=====Bem Vindo ao programa de Geometria=====");
Console.WriteLine();

Console.WriteLine($"Vamos calcular a área do retângulo:");

Console.Write($"Informe a altura:");
float altura = float.Parse(Console.ReadLine());
Console.Write($"Informe a largura:");
float largura = float.Parse(Console.ReadLine());

//cria a variável objeto da classe retangulo
Retangulo R = new Retangulo(largura, altura);
Console.WriteLine();



Console.WriteLine($"Agora, vamos para a Área do retângulo");

Console.Write($"Informe o raio do círculo:");
float raio = float.Parse(Console.ReadLine());

Circulo C = new Circulo();
C.Raio = raio;



R.CalcularArea();
C.CalcularArea();

//Escreva     um     programa que leia     as     medidas     dos     lados     de     um     triângulo     e    escreva    se  
// ele    é    Equilátero,    Isósceles    ou    Escaleno.    Sendo    que:     

//− Triângulo    Equilátero:    possui    os    3    lados    iguais.     
//− Triângulo    Isóscele:    possui    2    lados    iguais.     
//− Triângulo    Escaleno:    possui    3    lados    diferentes.


int lado1, lado2, lado3;

Console.WriteLine("Seja bem-vindo(a) ao nosso programa: ");
Console.WriteLine();
Console.WriteLine("Digite a medida do primeiro lado");
lado1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a medida do segundo lado");
lado2 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a medida do terceiro lado");
lado3 = int.Parse(Console.ReadLine());

if (lado1 == lado2 && lado2 == lado3)
{
    Console.WriteLine("Triângulo Equilátero");
}
else if (lado1 != lado2 && lado2 != lado3)
{
    Console.WriteLine("Triângulo Escaleno");
}
else
{
    Console.WriteLine("Triângulo Isóceles");
}

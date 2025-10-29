//Escreva     um     programa     que     verifique     a     validade     de     uma     senha     fornecida pelo     usuário.     A     senha     válida     é     o     número     1234.    Devem     ser    impressas     as    seguintes     mensagens:     

// - ACESSO    PERMITIDO    caso    a    senha    seja    válida.     
// - ACESSO    NEGADO    caso    a    senha    seja    inválida

int senha = 1234, senhaU;

Console.WriteLine("Seja bem-vindo(a) ao nosso programa: ");
Console.WriteLine();
Console.WriteLine("Digite a senha");
senhaU = int.Parse(Console.ReadLine());

if (senha == senhaU)
{
    Console.WriteLine("ACESSO    PERMITIDO");
}
else
{
    Console.WriteLine("ACESSO    NEGADO");
}
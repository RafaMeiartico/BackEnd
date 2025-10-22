//Pedir para o usúario digitar o nome, sobrenome, idade, saldo bancário e quanto investiu esse ano

string nome;
string sobrenomeDoFulano;
int idade;
float saldoConta;
float investimento;

Console.WriteLine("Qual é o seu nome?");
nome = Console.ReadLine();

Console.WriteLine("Qual é o seu sobrenome?");
sobrenomeDoFulano = Console.ReadLine();

Console.WriteLine("Qual é a sua idade?");
idade = int.Parse( Console.ReadLine() );

Console.WriteLine("Qual é seu saldo bancário?");
saldoConta = float.Parse(Console.ReadLine());

//receber o investimento do usuário
Console.WriteLine("Qual é o total de seus investimentos atuais?");
investimento = float.Parse(Console.ReadLine());

Console.Clear(); //limpa o console

Console.WriteLine("Saída de Dados:");
Console.WriteLine($"Nome: {nome} {sobrenomeDoFulano}");
Console.WriteLine($"A idade do(a) {nome} é {idade}");
Console.WriteLine($"Saldo bancário: R${saldoConta}");
Console.WriteLine($"Investimento: R$ {investimento}");
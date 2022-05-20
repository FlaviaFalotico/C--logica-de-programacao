/*
 Fazer um programam para executar a seguinte interação com o usuário, lendo os valores indicados e apresentar os dados na tela:

Entre com o sue nome completo:
Alex Green

Quantos quartos tem a sua casa?
3

Entre com o preço de um produto:
500.50

Entre com o seu último nome completo, idade e altura (na mesma linha, separados por um traço):
Alex Green - 21 - 1,73.
 */

Console.WriteLine("Entre com o seu nome completo: ");
string nome = Console.ReadLine();

Console.WriteLine();
Console.WriteLine("Quantos quartos tem a sua casa? ");
int quartos = int.Parse(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("Entre com o preço de um produto: ");
double preco = double.Parse(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("Entre com o seu primeiro nome, idade e altura (na mesma linha, separados por um traço): ");
string[] vet = Console.ReadLine().Split('-');
string primeiroNome = vet[0];
int idade = int.Parse(vet[1]);
double altura = double.Parse(vet[2]);

Console.WriteLine();
Console.WriteLine("Você digitou: ");
Console.WriteLine(nome + ".");
Console.WriteLine(quartos + " quartos.");
Console.WriteLine("R$" + preco.ToString("F2") + ".");
Console.WriteLine(primeiroNome + ".");
Console.WriteLine(idade + " anos.");
Console.WriteLine(altura.ToString("F2") + "cm.");
/*
 Entendo as entradas e comando Split

Checklist 

• Ler um número inteiro
• Ler um caractere
• Ler um número double

• Ler um nome (única palavra), sexo
(caractere F ou M), idade (inteiro) e
altura (double) na mesma linha,
armazenando-os em quatro
variáveis com os devidos tipos.
*/

//Até esse momento o usuário está informando os dados de forma isolada:
Console.WriteLine("Informe um numero inteiro: ");
int n1 = int.Parse(Console.ReadLine());

Console.WriteLine("Informe uma letra: ");
char ch = char.Parse(Console.ReadLine());

Console.WriteLine("Informe um número decimal: ");
double n2 = double.Parse(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("Você digitou:");
Console.WriteLine(n1);
Console.WriteLine(ch);
Console.WriteLine(n2.ToString("F2"));


//Utilizando o comando Split para escrever dados na mesma linha, mas com quatro variáveis diferentes:
Console.WriteLine();
Console.WriteLine("Informe o seu primeiro nome, sexo (F ou M), idade (apenas números inteiros) e altura,\n" +
    "separados por um traço e simples:");


string[] minhaVariavel = Console.ReadLine().Split('-');

string nome = minhaVariavel[0];
char sexo = char.Parse(minhaVariavel[1]);
int idade = int.Parse(minhaVariavel[2]);
double altura = double.Parse(minhaVariavel[3]);

Console.WriteLine();
Console.WriteLine("Você digitou: ");
Console.WriteLine(nome);
Console.WriteLine(sexo);
Console.WriteLine(idade);
Console.WriteLine(altura.ToString("F2"));

Console.WriteLine($"\nVocê digitou: {nome} - {sexo} - {idade}anos - {altura}m.");
Console.ReadLine();
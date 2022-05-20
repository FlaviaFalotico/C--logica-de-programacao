/*CheckList:
1 - Ler um número inteiro - armazenar na variável n1
2 - ler um caractere - armazenar na variável ch
3 - ler um número double - armazenar na variável n2
4 - Ler um nome (única palavra), sexo, (caractere F ou M), idade (inteiro) e altura (double) na mesma linha,
armazenando-os em quatro variáveis com o s seus devidos tipos.

Admita:
n1 = 35
ch = F
n2 = 1,68

Maria F 35 1,68
*/

int n1 = int.Parse(Console.ReadLine());
char ch = char.Parse(Console.ReadLine());
double n2 = double.Parse(Console.ReadLine());

string[] vet = Console.ReadLine().Split(' ');
string nome = vet[0];
char sexo = char.Parse(vet[1]);
int idade = int.Parse(vet[2]);
double altura = double.Parse(vet[3]);

Console.WriteLine("Você digitou: ");
Console.WriteLine(n1);
Console.WriteLine(ch);
Console.WriteLine(n2.ToString("F2"));
Console.WriteLine(nome);
Console.WriteLine(sexo);
Console.WriteLine(idade);
Console.WriteLine(altura.ToString("F2"));
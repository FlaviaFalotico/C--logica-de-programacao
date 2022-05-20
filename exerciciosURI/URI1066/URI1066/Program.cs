/*
Pares, Ímpares, Positivos e Negativos

Leia 5 valores Inteiros. A seguir mostre quantos valores digitados foram pares, quantos valores digitados 
foram ímpares, quantos valores digitados foram positivos e quantos valores digitados foram negativos.

Entrada
O arquivo de entrada contém 5 valores inteiros quaisquer.

Saída
Imprima a mensagem conforme o exemplo fornecido, uma mensagem por linha, 
não esquecendo o final de linha após cada uma.

Exemplo de Entrada	Exemplo de Saída

-5                  3 valor(es) par(es)
0                   2 valor(es) impar(es)
-3                  1 valor(es) positivo(s)
-4                  3 valor(es) negativo(s)
12 
*/

Console.WriteLine("Digite cinco valores, entre positiovs e negativos: ");

int a, b, c, d, e, pares, impares, positivos, negativos;

pares = 0;
impares = 0;
positivos = 0;
negativos = 0;

a = int.Parse(Console.ReadLine());
if (a % 2 == 0)
{
    pares++;
}
else
{
    impares++;
}
if (a > 0)
{
    positivos++;
}
else if (a < 0)
{
    negativos++;
}

b = int.Parse(Console.ReadLine());
if (b % 2 == 0)
{
    pares++;
}
else
{
    impares++;
}
if (b > 0)
{
    positivos++;
}
else if (b < 0)
{
    negativos++;
}

c = int.Parse(Console.ReadLine());
if (c % 2 == 0)
{
    pares++;
}
else
{
    impares++;
}
if (c > 0)
{
    positivos++;
}
else if (c < 0)
{
    negativos++;
}

d = int.Parse(Console.ReadLine());
if (d % 2 == 0)
{
    pares++;
}
else
{
    impares++;
}
if (d > 0)
{
    positivos++;
}
else if (d < 0)
{
    negativos++;
}

e = int.Parse(Console.ReadLine());
if (e % 2 == 0)
{
    pares++;
}
else
{
    impares++;
}
if (e > 0)
{
    positivos++;
}
else if (e < 0)
{
    negativos++;
}

Console.WriteLine(pares + " valor(es) par(es)");
Console.WriteLine(impares + " valor(es) impar(es)");
Console.WriteLine(positivos + " valor(es) positivo(s)");
Console.WriteLine(negativos + " valor(es) negativo(s)");
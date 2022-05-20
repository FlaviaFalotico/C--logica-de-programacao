/*
Números Positivos

Faça um programa que leia 6 valores. Estes valores serão somente negativos ou positivos 
(desconsidere os valores nulos). A seguir, mostre a quantidade de valores positivos digitados.

Entrada
Seis valores, negativos e/ou positivos.

Saída
Imprima uma mensagem dizendo quantos valores positivos foram lidos.

Exemplo de Entrada	Exemplo de Saída
7                   4 valores positivos
-5
6
-3.4
4.6
12
*/

Console.WriteLine("Digite seis valores, entre positiovs e/ou negativos: ");
double a, b, c, d, e, f;
string[] valores = Console.ReadLine().Split(' ');
a = double.Parse(valores[0]);
b = double.Parse(valores[1]);
c = double.Parse(valores[2]);
d = double.Parse(valores[3]);
e = double.Parse(valores[4]);
f = double.Parse(valores[5]);

int cont = 0;
if (a > 0.0)
{
    cont = cont + 1;
}
if (b > 0.0)
{
    cont = cont + 1;
}
if (c > 0.0)
{
    cont = cont + 1;
}
if (d > 0.0)
{
    cont = cont + 1;
}
if (e > 0.0)
{
    cont = cont + 1;
}
if (f > 0.0)
{
    cont = cont + 1;
}
Console.WriteLine(cont + " valores positivos");

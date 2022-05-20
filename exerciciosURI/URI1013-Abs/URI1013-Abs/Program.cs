/*
O Maior

Faça um programa que leia três valores e apresente o maior dos três valores lidos seguido da mensagem “eh o maior”. 

Utilize a fórmula:

MaiorAB = (a + b + abs(a - b)) / 2,0

Obs.: a fórmula apenas calcula o maior entre os dois primeiros (a e b). Um segundo passo, portanto é necessário para 
chegar no resultado esperado.

Entrada
O arquivo de entrada contém três valores inteiros.

Saída
Imprima o maior dos três valores seguido por um espaço e a mensagem "eh o maior".

Exemplos de Entrada	e Saída

Entrada:
7 14 106
Saída:
106 eh o maior

Entrada:
217 14 6
Saída:
217 eh o maior
*/

double a, b, c, d, maiorAB, maiorNum;

string[] vet = Console.ReadLine().Split(' ');

a = double.Parse(vet[0]);
b = double.Parse(vet[1]);
c = double.Parse(vet[2]);

maiorAB = (a + b + Math.Abs(a - b)) / 2.0;

d = maiorAB;
maiorNum = (c + d + Math.Abs(c - d)) / 2.0;

Console.WriteLine(maiorNum + " eh o maior");
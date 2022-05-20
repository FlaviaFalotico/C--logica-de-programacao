/*
Pares entre Cinco Números

Faça um programa que leia 5 valores inteiros. Conte quantos destes valores digitados são pares e mostre esta informação.

Entrada
O arquivo de entrada contém 5 valores inteiros quaisquer.

Saída
Imprima a mensagem conforme o exemplo fornecido, indicando a quantidade de valores pares lidos.

Exemplo de Entrada	    Exemplo de Saída

7                       3 valores pares
-5
6
-4
12
*/

Console.WriteLine("Digite cinco valores, entre positiovs e negativos: ");
int a, b, c, d, e;
string[] valores = Console.ReadLine().Split(' ');
a = int.Parse(valores[0]);
b = int.Parse(valores[1]);
c = int.Parse(valores[2]);
d = int.Parse(valores[3]);
e = int.Parse(valores[4]);

int cont = 0;
if (a % 2 == 0.0)
{
    cont = cont + 1;
}
if (b % 2 == 0.0)
{
    cont = cont + 1;
}
if (c % 2 == 0.0)
{
    cont = cont + 1;
}
if (d % 2 == 0.0)
{
    cont = cont + 1;
}
if (e % 2 == 0.0)
{
    cont = cont + 1;;
}

Console.WriteLine(cont + " valores pares");
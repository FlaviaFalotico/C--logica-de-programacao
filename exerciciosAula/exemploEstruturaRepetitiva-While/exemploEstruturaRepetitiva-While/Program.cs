/*
Fazer um programa que lê números inteiros até que um zero seja lido. Ao final mostra a soma dos números lidos.

Exemplos de Entrada     Exemplos de Saída

5                       11
2
4
0
*/
int x, soma = 0;

x = int.Parse(Console.ReadLine());

while (x != 0)
{
    soma += x;
    x = int.Parse(Console.ReadLine());
}
Console.WriteLine(soma);
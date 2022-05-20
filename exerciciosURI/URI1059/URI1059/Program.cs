/*
Números Pares

Faça um programa que mostre os números pares entre 1 e 100, inclusive.

Entrada
Neste problema extremamente simples de repetição não há entrada.

Saída
Imprima todos os números pares entre 1 e 100, inclusive se for o caso, um em cada linha.

Exemplo de Entrada	Exemplo de Saída
                        2
                        4
                        6
                        ...
                        100
*/

//Utilizando o laço de repetição for:
int i;
for (i = 2; i <= 100; i = i + 2)
{
    Console.WriteLine(i);
}

//Utilizando if-else
int x = 0;
do
{
   x = x + 2;
   Console.WriteLine(x);
   
}while (x < 100);

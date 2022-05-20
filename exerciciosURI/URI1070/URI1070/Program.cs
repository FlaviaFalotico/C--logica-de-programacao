/*
Seis Números Ímpares

Leia um valor inteiro X. Em seguida apresente os 6 valores ímpares 
consecutivosa partir de X, um valor por linha, inclusive o X ser for o caso.

Entrada
A entrada será um valor inteiro positivo.

Saída
A saída será uma sequência de seis números ímpares.

Exemplo de Entrada	Exemplo de Saída

8                   9
                    11
                    13
                    15
                    17
                    19
*/


//Complementei o exercicio com um else, imaginando uma entrada de numeros positivos ou negativos:

int x = int.Parse(Console.ReadLine());

if (x % 2 == 0)
{
    x = x + 1;

    Console.WriteLine(x);
    Console.WriteLine(x + 2);
    Console.WriteLine(x + 4);
    Console.WriteLine(x + 6);
    Console.WriteLine(x + 8);
    Console.WriteLine(x + 10);
}
else
{
    x = x + 2;

    Console.WriteLine(x);
    Console.WriteLine(x + 2);
    Console.WriteLine(x + 4);
    Console.WriteLine(x + 6);
    Console.WriteLine(x + 8);
    Console.WriteLine(x + 10);
}

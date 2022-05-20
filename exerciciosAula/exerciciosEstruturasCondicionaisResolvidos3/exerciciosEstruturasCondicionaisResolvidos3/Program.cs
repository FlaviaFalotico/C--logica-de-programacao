/*
Fazer um programa para ler três números inteiros. Em seguida, mostrar qual o menor dentre
os 3 números lidos. Em caso de empate, mostrar apenas uma vez.

Exemplos de Entrada     Exemplos de Saída

7   3   8               MENOR = 3

5   12  5               MENOR = 5

9   9   9               MENOR = 9
*/

string[] valores = Console.ReadLine().Split(' ');

int A = int.Parse(valores[0]);
int B = int.Parse(valores[1]);
int C = int.Parse(valores[2]);

if (A == B && B == C)
{
    Console.WriteLine("MENOR = " + A);
}
else
{
    if (A < B && B < C)
    {
        Console.WriteLine("MENOR = " + A);
    }
    else if (B < A && A < C)
    {
        Console.WriteLine("MENOR = " + B);
    }
    else
    {
        Console.WriteLine("MENOR = " + C);
    }
}

/*
Condições feitas pelo professor:

if (x < y && x < z)
{
    Console.WriteLine("MENOR = " + x);
}
else if (y < z)
{
    Console.WriteLine("MENOR = " + y);
}
else 
{
    Console.WriteLine("MENOR = " + z);
}
*/
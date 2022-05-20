/*
Sort Simples

Leia 3 valores inteiros e ordene-os em ordem crescente. No final, mostre:

- os valores em ordem crescente, 
- uma linha em branco 
- em seguida, os valores na sequência como foram lidos.

Entrada
A entrada contem três números inteiros.

Saída
Imprima a saída conforme foi especificado.

Exemplo de Entrada	Exemplo de Saída
7 21 -14            -14
                    7
                    21
                    linha em branco
                    7
                    21
                    -14

-14 21 7            -14
                    7
                    21
                    linha em branco
                    -14
                    21
                    7
*/

/// <summary>
/// Aramzenam três valores digitados pelo usuário.
/// </summary>
int valor1, valor2, valor3;

string[] valores = Console.ReadLine().Split(' ');
valor1 = int.Parse(valores[0]);
valor2 = int.Parse(valores[1]);
valor3 = int.Parse(valores[2]);

if (valor1 < valor2 && valor2 < valor3)
{
    Console.WriteLine(valor1);
    Console.WriteLine(valor2);
    Console.WriteLine(valor3);
    Console.WriteLine();
    Console.WriteLine(valor1);
    Console.WriteLine(valor2);
    Console.WriteLine(valor3);
}
else if (valor1 < valor3 && valor3 < valor2)
{
    Console.WriteLine(valor1);
    Console.WriteLine(valor3);
    Console.WriteLine(valor2);
    Console.WriteLine();
    Console.WriteLine(valor1);
    Console.WriteLine(valor2);
    Console.WriteLine(valor3);
}
else if (valor2 < valor1 && valor1 < valor3)
{
    Console.WriteLine(valor2);
    Console.WriteLine(valor1);
    Console.WriteLine(valor3);
    Console.WriteLine();
    Console.WriteLine(valor1);
    Console.WriteLine(valor2);
    Console.WriteLine(valor3);
}
else if (valor2 < valor3 && valor3 < valor1)
{
    Console.WriteLine(valor2);
    Console.WriteLine(valor3);
    Console.WriteLine(valor1);
    Console.WriteLine();
    Console.WriteLine(valor1);
    Console.WriteLine(valor2);
    Console.WriteLine(valor3);
}
else if (valor3 < valor1 && valor1 < valor2)
{
    Console.WriteLine(valor3);
    Console.WriteLine(valor1);
    Console.WriteLine(valor2);
    Console.WriteLine();
    Console.WriteLine(valor1);
    Console.WriteLine(valor2);
    Console.WriteLine(valor3);
}
else
{
    Console.WriteLine(valor3);
    Console.WriteLine(valor2);
    Console.WriteLine(valor1);
    Console.WriteLine();
    Console.WriteLine(valor1);
    Console.WriteLine(valor2);
    Console.WriteLine(valor3);
}
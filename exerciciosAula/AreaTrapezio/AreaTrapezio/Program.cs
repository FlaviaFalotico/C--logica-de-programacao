//Construa um programa em C# para calcular a área de um trapézio, cuja altura é igual a 5 e as bases são respectivamente 8 e 6.

Console.WriteLine("Qual é a medida da área de um trapézio cuja altura é igual a 5 \n" +
    "e as bases são respectivamente 8 e 6?");

double B, b, h, area;

B = 8.0;
b = 6.0;
h = 5.0;

area = (B + b) / 2 * h;
Console.WriteLine();
Console.WriteLine("A área do trapézio cuja a base maior é: " + B + "cm, a base menor \n" +
    "é igual a: " + b + "cm e a altura mede: " + h + "cm, coresponde a: " + area + "cm^2.");

//Boa prática: Sempre indique o tipo do número, se a expressão for de ponto flutuante (não inteira).
//Para double use: .0
//Para float use: f

float B, b, h, area;
B = 8f;
b = 6f;
h = 5f;

area = (B + b) / 2f * h;

//Nesse exemplo, o resultado trará apenas a parte inteira da divisão, pois o tipo de dado escolhido é do tipo inteiro.
int a, b;
double resultado;

a = 5;
b = 2;

resultado = a / b;
Console.WriteLine(resultado);

//Para recebermos o valor da divisão, como 2,5, precisamos fazer uma conversão:
//Casting
//É a conversão explícita de um tipo para outro.
//É necessário quando o compilador não é capaz de “adivinhar” que o
//resultado de uma expressão deve ser de outro tipo.
//Então teremos:
int a, b;
double resultado;

a = 5;
b = 2;

resultado = (double) a / b;
Console.WriteLine(resultado);
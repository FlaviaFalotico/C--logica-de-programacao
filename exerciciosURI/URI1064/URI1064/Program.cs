/*
Positivos e Média

Leia 6 valores. Em seguida, mostre quantos destes valores digitados foram positivos. Na próxima linha, 
deve-se mostrar a média de todos os valores positivos digitados, com um dígito após o ponto decimal.

Entrada
A entrada contém 6 números que podem ser valores inteiros ou de ponto flutuante. 
Pelo menos um destes números será positivo.

Saída
O primeiro valor de saída é a quantidade de valores positivos. 
A próxima linha deve mostrar a média dos valores positivos digitados.

Exemplo de Entrada	        Exemplo de Saída

7                           4 valores positivos
-5                          7.4
6
-3.4
4.6
12
*/

Console.WriteLine("Digite seis valores, entre positiovs e/ou negativos: ");
double a, b, c, d, e, f, media;
string[] valores = Console.ReadLine().Split(' ');
a = double.Parse(valores[0]);
b = double.Parse(valores[1]);
c = double.Parse(valores[2]);
d = double.Parse(valores[3]);
e = double.Parse(valores[4]);
f = double.Parse(valores[5]);

int cont = 0;
double soma = 0.0;
if (a > 0.0)
{
    cont = cont + 1;
    soma = soma + a;
}
if (b > 0.0)
{
    cont = cont + 1;
    soma = soma + b;
}
if (c > 0.0)
{
    cont = cont + 1;
    soma = soma + c;
}
if (d > 0.0)
{
    cont = cont + 1;
    soma = soma + d;
}
if (e > 0.0)
{
    cont = cont + 1;
    soma = soma + e;
}
if (f > 0.0)
{
    cont = cont + 1;
    soma = soma + f;
}
Console.WriteLine(cont + " valores positivos");

media = soma / cont;
Console.WriteLine(media.ToString("F1"));
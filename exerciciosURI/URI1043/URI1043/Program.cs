/*
Triângulo

Leia 3 valores reais (A, B e C) e verifique se eles formam ou não um triângulo. 

Em um triângulo, segundo a condição de existência, temos que:

a + b > c

b + c > a

a + c > b

Em caso positivo, calcule o perímetro do triângulo e apresente a mensagem:

Perimetro = XX.X

Em caso negativo, calcule a área do trapézio que tem A e B como base e C como altura, mostrando a mensagem

Area = XX.X

Entrada
A entrada contém três valores reais.

Saída
O resultado deve ser apresentado com uma casa decimal.

Exemplo de Entrada	Exemplo de Saída

6.0 4.0 2.0         Area = 10.0

6.0 4.0 2.1         Perimetro = 12.1 
*/

double A, B, C, perimetro, area;

string[] valores = Console.ReadLine().Split(' ');
A = double.Parse(valores[0]);
B = double.Parse(valores[1]);
C = double.Parse(valores[2]);

if (A + B > C && B + C > A && A + C > B)
{
    perimetro = A + B + C;
    Console.WriteLine("Perimetro = " + perimetro.ToString("F1"));
}
else
{
    area = ((A + B) * C) / 2.0;
    Console.WriteLine("Area = " + area.ToString("F1"));
}
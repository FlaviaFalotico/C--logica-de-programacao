/*
Área

Escreva um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e mostre:

a) a área do triângulo retângulo que tem A por base e C por altura.
areaTrianguloRetangulo = base * altura / 2.0

b) a área do círculo de raio C. (pi = 3.14159)
areaCirculo = 2.0 * pi * raio

c) a área do trapézio que tem A e B por bases e C por altura.
areaTrapezio = (Base + base) / 2.0

d) a área do quadrado que tem lado B.
areaQuadrado = lado * lado

e) a área do retângulo que tem lados A e B.
areaRetangulo = base * altura

Entrada
O arquivo de entrada contém três valores com um dígito após o ponto decimal.

Saída
O arquivo de saída deverá conter 5 linhas de dados. Cada linha corresponde a uma das áreas descritas acima, sempre com 
mensagem correspondente e um espaço entre os dois pontos e o valor. O valor calculado deve ser apresentado com 3 dígitos 
após o ponto decimal.

Exemplos de Entrada	e Saída

Entrada:
3.0 4.0 5.2

Saída:
TRIANGULO: 7.800
CIRCULO: 84.949
TRAPEZIO: 18.200
QUADRADO: 16.000
RETANGULO: 12.000

Entrada:
12.7 10.4 15.2

Saída:
TRIANGULO: 96.520
CIRCULO: 725.833
TRAPEZIO: 175.560
QUADRADO: 108.160
RETANGULO: 132.080
*/

double areaTriangulo, areaCirculo, areaTrapezio, areaQuadrado, areaRetangulo;

string[] vet = Console.ReadLine().Split(' ');

double A = double.Parse(vet[0]);
double B = double.Parse(vet[1]);
double C = double.Parse(vet[2]);

areaTriangulo = A * C / 2.0;
areaCirculo = 3.14159 * Math.Pow(C, 2.0);
areaTrapezio = (A + B) / 2.0 * C;
areaQuadrado = Math.Pow(B, 2.0);
areaRetangulo = A * B;

Console.WriteLine("TRIANGULO: " + areaTriangulo.ToString("F3"));
Console.WriteLine("CIRCULO: " + areaCirculo.ToString("F3"));
Console.WriteLine("TRAPEZIO: " + areaTrapezio.ToString("F3"));
Console.WriteLine("QUADRADO: " + areaQuadrado.ToString("F3"));
Console.WriteLine("RETANGULO: " + areaRetangulo.ToString("F3"));
/*
Distância Entre Dois Pontos

Leia os quatro valores correspondentes aos eixos x e y de dois pontos quaisquer no plano, p1(x1,y1) e p2(x2,y2) 
e calcule a distância entre eles, mostrando 4 casas decimais após a vírgula, segundo a fórmula:

distancia = √(x2 - x1)² + (y2 - y1)²

Entrada
O arquivo de entrada contém duas linhas de dados. A primeira linha contém dois valores de ponto flutuante: x1 y1 
e a segunda linha contém dois valores de ponto flutuante x2 y2.

Saída
Calcule e imprima o valor da distância segundo a fórmula fornecida, com 4 casas após o ponto decimal.

Exemplo de Entrada e Saída

Entrada
1.0 7.0
5.0 9.0

Saída
4.4721

Entrada
-2.5 0.4
12.1 7.3

Saída
16.1484

Entrada
2.5 -0.4
-12.2 7.0

Saída
16.4575
*/
string[] valores = Console.ReadLine().Split(' ');

double x1 = double.Parse(valores[0]);
double y1 = double.Parse(valores[1]);

valores = Console.ReadLine().Split(' ');

double x2 = double.Parse(valores[0]);
double y2 = double.Parse(valores[1]);

double distancia = Math.Sqrt(Math.Pow(x2 - x1, 2.0) + Math.Pow(y2 - y1, 2.0));

Console.WriteLine(distancia.ToString("F4"));
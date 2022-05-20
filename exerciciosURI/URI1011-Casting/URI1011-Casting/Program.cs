/*
Esfera

Faça um programa que calcule e mostre o volume de uma esfera sendo fornecido o valor de seu raio (R). 
A fórmula para calcular o volume é: (4/3) * pi * R3. Considere (atribua) para pi o valor 3.14159.

Dica: Ao utilizar a fórmula, procure usar (4/3.0) ou (4.0/3), pois algumas linguagens (dentre elas o C++), 
assumem que o resultado da divisão entre dois inteiros é outro inteiro.

Entrada
O arquivo de entrada contém um valor de ponto flutuante (dupla precisão), correspondente ao raio da esfera.

Saída
A saída deverá ser uma mensagem "VOLUME" conforme o exemplo fornecido abaixo, com um espaço antes e um espaço 
depois da igualdade. O valor deverá ser apresentado com 3 casas após o ponto.

Exemplos de Entrada	e de Saída

Entrada:
3
Saída:
VOLUME = 113.097

Entrada:
15
Saída:
VOLUME = 14137.155

Entrada:
1523
Saída:
VOLUME = 14797486501.627

INTERPRETAÇÃO:

Como já dito, o volume da esfera é calculado através da seguinte fórmula:

Ve = 4. p.r³/ 3
*/

double volume, pi, raio;

pi = 3.14159;
Console.WriteLine("Informe um valor para o raio da esfera:");
raio = double.Parse(Console.ReadLine());

volume = 4.0 * pi * Math.Pow(raio, 3.0) / 3.0;

Console.WriteLine("VOLUME = " + volume.ToString("F3"));
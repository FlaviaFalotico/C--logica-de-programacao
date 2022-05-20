/*
Coordenadas de um Ponto

Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas de um ponto em um plano. 
A seguir, determine qual o quadrante ao qual pertence o ponto, ou se está sobre um dos eixos cartesianos ou na origem (x = y = 0).
                                            y
                                           |
                                     Q2    |    Q1
                                 __________|__________x
                                           |
                                     Q3    |    Q4
                                           |

Se o ponto estiver na origem, escreva a mensagem “Origem”.
Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a situação.

Entrada
A entrada contem as coordenadas de um ponto.

Saída
A saída deve apresentar o quadrante em que o ponto se encontra.

Exemplo de Entrada	Exemplo de Saída

4.5 -2.2            Q4

0.1 0.1             Q1

0.0 0.0             Origem
*/

float x, y;

Console.WriteLine("Informe o valores para o eixos x e y, respectivamente: ");
string[] coordenadas = Console.ReadLine().Split(' ');
x = float.Parse(coordenadas[0]);
y = float.Parse(coordenadas[1]);

if (x == 0 && x == y)
{
    Console.WriteLine("Origem");
}
else
{
    if(x > 0 && y > 0)
    {
        Console.WriteLine("Q1");
    }
    else if (x < 0 && y > 0)
    {
        Console.WriteLine("Q2");
    }
    else if (x < 0 && y < 0)
    {
        Console.WriteLine("Q3");
    }
    else if (x > 0 && y < 0)
    {
        Console.WriteLine("Q4");
    }
    else if (x == 0)
    {
        Console.WriteLine("Eixo X");
    }
    else
    {
        Console.WriteLine("Eixo Y");
    }
}
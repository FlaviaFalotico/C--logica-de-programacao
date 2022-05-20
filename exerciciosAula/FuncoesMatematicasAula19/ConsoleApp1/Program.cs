/*
int ano = 2022;
Console.WriteLine(ano);

Operações aritméticas clássicas:

soma                +
subtração           -
multiplicação       *
divisão             /
divisão para resto %

Ano bisiestos são anos que ao serem dividos por 4 resultam em resto 0.

int resto = 2022 % 4;
Console.WriteLine(resto);

int resto = 2022 % 100;
Console.WriteLine(resto);
*/

double x = 3.0;
double y = 4.0;
double z = -5.0;
double A, B, C;

A = Math.Sqrt(x);
B = Math.Sqrt(y);
C = Math.Sqrt(25.0);
Console.WriteLine("A r  aiz quadrada de " + x + " é igual a " + A + ".");
Console.WriteLine("A raiz quadrada de " + y + " é igual a " + B + ".");
Console.WriteLine("A raiz quadrada de 25 é igual a " + C + ".");

A = Math.Pow(x, y);
B = Math.Pow(y, 2.0);
C = Math.Pow(5.0, 2.0);
Console.WriteLine(x + " elevado a " + y + " é igual a " + A + ".");
Console.WriteLine(y + " elevado ao quadrado é igual a " + B + ".");
Console.WriteLine("5 elevado ao quadrado é igual a " + C + ".");

A = Math.Abs(y);
B = Math.Abs(z);
Console.WriteLine("O valor absoluto de " + y + " é igual a " + A);
Console.WriteLine("O valor absoluto de " + z + " é igual a " + B);

/*Fórmula de Baskara
 
delta = Math.Pow(b, 2.0) - 4*a*c;

x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);
 
 */

/*
Problema exemplo:

Fazer um programa para ler uma temperatura em Celsius e mostrar o equivalente em Fahrenheit. 
Perguntar se o usuário deseja repetir (s/n). Caso o usuário digite "s", repetir o programa.

Fórmula:  F = (9 * C / 5) + 32;

Exemplo:

Digite a temperatura em Celsius: 30.0
Equivalente em Fahrenheit: 86.0
Deseja repetir (s/n)? s
Digite a temperatura em Celsius: 21.0
Equivalente em Fahrenheit: 69.8
Deseja repetir (s/n)? s
Digite a temperatura em Celsius: -10.5
Equivalente em Fahrenheit: 13.1
Deseja repetir (s/n)? n 
*/

double temperaturaCelcius = 0;
double conversaoTemperatura = 0;
char resposta = ' ';

do
{
    Console.Clear();
    Console.Write("Digite a temperatura em Celsius: ");
    temperaturaCelcius = double.Parse(Console.ReadLine());

    conversaoTemperatura = 9.0 * temperaturaCelcius / 5.0 + 32.0;
    Console.WriteLine("Equivalente em Fahrenheit: " + conversaoTemperatura.ToString("F1") + "ºF.");
    
    Console.Write("Deseja repetir (s/n)? ");
    resposta = char.Parse(Console.ReadLine().ToLower());
    Console.ReadKey();

} while (resposta != 'n');

//Resolução professor Nélio: 

//Para utilizarmos a estrutura while temos duas maneiras:

//1-) Menos indicada: começar o programa antes da estrutura de repeticção:
/*
double C, F;
char repetir;

Console.Write("Digite a temperatura em Celsius: ");
C = double.Parse(Console.ReadLine());
F = 9.0 * C / 5.0 + 32.0;
Console.WriteLine("Equivalente em Fahrenheit: " + F.ToString("F1") + "ºF.");
Console.Write("Deseja repetir (s/n)? ");
repetir = char.Parse(Console.ReadLine().ToLower());

while (repetir == 's')
{
Console.Write("Digite a temperatura em Celsius: ");
C = double.Parse(Console.ReadLine());
F = 9.0 * C / 5.0 + 32.0;
Console.WriteLine("Equivalente em Fahrenheit: " + F.ToString("F1") + "ºF.");
Console.Write("Deseja repetir (s/n)? ");
repetir = char.Parse(Console.ReadLine().ToLower());
}
*/

//1-) Com truque: inicializar a várial resposta com a condição favorável, no caso, 's':
/*
double C, F;
char repetir = 's';

while (repetir == 's')
{
Console.Write("Digite a temperatura em Celsius: ");
C = double.Parse(Console.ReadLine());
F = 9.0 * C / 5.0 + 32.0;
Console.WriteLine("Equivalente em Fahrenheit: " + F.ToString("F1") + "ºF.");
Console.Write("Deseja repetir (s/n)? ");
repetir = char.Parse(Console.ReadLine().ToLower());
}
*/

//Estrutura de Repetição do-while:
double C, F;
char repetir;

do
{
    Console.Write("Digite a temperatura em Celsius: ");
    C = double.Parse(Console.ReadLine());
    F = 9.0 * C / 5.0 + 32.0;
    Console.WriteLine("Equivalente em Fahrenheit: " + F.ToString("F1"));
    Console.Write("Deseja repetir (s/n)? ");
    repetir = char.Parse(Console.ReadLine().ToLower());
} while (resposta == 's');
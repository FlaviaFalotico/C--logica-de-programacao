// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

double x = 10.35768;
int y = 32;
string z = "Maria";
char w = 'F';
int a = 5;
int b = 2 * a;

Console.WriteLine();
Console.WriteLine(x);
Console.WriteLine(x.ToString("F2"));
Console.WriteLine(x.ToString("F4"));

Console.WriteLine();
Console.WriteLine("RESULTADO = " + x);
Console.WriteLine("O valor do troco é de " + x + " reais.");
Console.WriteLine("O valor do troco é de R$" + x.ToString("F2") + ".");

Console.WriteLine();
Console.WriteLine("A paciente " + z + " tem " + y + " anos e seu sexo é: " + w + ".");

Console.WriteLine();
Console.WriteLine(a);
Console.WriteLine(b);

Console.ReadLine();

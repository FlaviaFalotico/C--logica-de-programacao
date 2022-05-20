Console.WriteLine("Informe o valor que deseja sacar: ");
int a = int.Parse(Console.ReadLine());

int b, divisao, resto;

b = 200;
divisao = a / b;
Console.WriteLine("quantidade de nota de 200: " + divisao);
resto = a % b;
b = 100;

divisao = resto / b;
Console.WriteLine("quantidade de nota de 100: " + divisao);
resto = a % b;
b = 50;

divisao = resto / b;
Console.WriteLine("quantidade de nota de 50: " + divisao);
resto = a % b;
b = 20;

divisao = resto / b;
Console.WriteLine("quantidade de nota de 20: " + divisao);
resto = a % b;
b = 10;

divisao = resto / b;
Console.WriteLine("quantidade de nota de 10: " + divisao);
resto = a % b;
b = 5;

divisao = resto / b;
Console.WriteLine("quantidade de nota de 5: " + divisao);
resto = a % b;
b = 2;

divisao = resto / b;
Console.WriteLine("quantidade de nota de 2: " + divisao);
resto = a % b;
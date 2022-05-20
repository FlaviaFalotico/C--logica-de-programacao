/*
Fazer um programa para ler as medidas da base e altura de um retângulo. Em seguida, mostrar o 
valor da área, perímetro e diagonal deste retângulo, com quatro casas decimais, conforme exemplo.

Entrada: 

5.0
4.0

Saída:

AREA = 20.0000
PERIMETRO = 18.0000
DIAGONAL = 6.4031

Interpretação:

area = b * h
perimetro = 2 * (b + h)
diagonal do retângulo: "d² = b² + h²" ou  "d = √(b² + h²)"
*/

double b, h, area, perimetro, diagonal;

Console.WriteLine("Informe o valor da base do retângulo: ");
b = double.Parse(Console.ReadLine());

Console.WriteLine("Informe o valor da altura do retângulo: ");
h = double.Parse(Console.ReadLine());

area = b * h;
perimetro = 2 * (b + h);
diagonal = Math.Sqrt(Math.Pow(b,2.0) + Math.Pow(h,2.0));

//Na fórmula acima poderia ter feito: diagonal = Math.Sqrt(b * b + h * h);
//Porém, exercicitamos o uso de funções matemáticas.

Console.WriteLine();
Console.WriteLine("Os valores obtidos para a área, perímetro e diagonal do retângulo são, respectivamente: ");
Console.WriteLine("A = " + area.ToString("F4"));
Console.WriteLine("p = " + perimetro.ToString("F4"));
Console.WriteLine("d = " + diagonal.ToString("F4"));

Console.ReadLine();
/*
Fazer um programa para ler as medidas da largura e comprimento de um terreno
retangular com uma casa decimal, bem como o valor do metro quadrado do
terreno com duas casas decimais. Em seguida, o programa deve mostrar o valor
da área do terreno, bem como o valor do preço do terreno, ambos com duas
casas decimais, conforme exemplo.

Exemplo:

Entrada         Saída
10.0            AREA = 300.00
30.0            PRECO = 60000.00
200.0
*/

Console.WriteLine("Bem-vindo(a)! Você acaba de acessar à calculadora de preços de terrenos:");

Console.WriteLine();
Console.WriteLine("Informe a medida da largura do terreno em m: ");
double largura = double.Parse(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("Informe a medida do comprimento do terreno em m: ");
double comprimento = double.Parse(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("Informe o valor do m² do terreno: ");
double precoMetro = double.Parse(s: Console.ReadLine());

double area, precoTotal;
area = largura * comprimento;
precoTotal = area * precoMetro;

Console.WriteLine();
Console.WriteLine("Informações recebidas sobre o terreno:");
Console.WriteLine();
Console.WriteLine("A medida da largura do terreno iformada é de " + largura.ToString("F1") + "m.");
Console.WriteLine("A medida docomprimento do terreno iformada é de " + comprimento.ToString("F1") + "m.");
Console.WriteLine("O o valor informado para o m² do terreno é de R$" + precoMetro.ToString("F2") + ".");

Console.WriteLine();
Console.WriteLine("Cálculos da área e valor do terreno:");
Console.WriteLine();
Console.WriteLine("A área total do terreno retângular é igual a: " + area.ToString("F2") + "m².");
Console.WriteLine("O valor total calculado para o terreno é de R$" + precoTotal.ToString("F2") + ".");

Console.WriteLine();
Console.WriteLine("Agradecemos a preferência!");

/*
 Solução do Professor:

double largura, comprimento, precoMetroQuadrado, area, precoTotal;

largura = double.Parse(ConsoleLine());
comprimento = double.Parse(ConsoleLine());
precoMetroQuadrado = double.Parse(ConsoleLine());

area = largura * comprimento;
precoTotal = area * precoMetroQuadrado;

Console.WriteLine("AREA = " + area.ToString("F2"));
Console.WriteLine("PRECO = " + precoTotal.ToString("F2"));

Console.ReadLine();

 */
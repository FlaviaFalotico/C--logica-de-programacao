/*
Aumento de Salário

A empresa ABC resolveu conceder um aumento de salários 
a seus funcionários de acordo com a tabela abaixo:

      Salário	            Percentual de Reajuste
      0 - 400.00                15% = 0,15
      400.01 - 800.00           12% = 0,12
      800.01 - 1200.00          10% = 0,10
      1200.01 - 2000.00          7% = 0,07
      Acima de 2000.00           4% = 0,04

Leia o salário do funcionário e calcule e mostre o novo salário, bem 
como o valor de reajuste ganho e o índice reajustado, em percentual.

Entrada
A entrada contém apenas um valor de ponto flutuante, com duas casas decimais.

Saída
Imprima 3 linhas na saída: o novo salário, o valor ganho de reajuste e o 
percentual de reajuste ganho, conforme exemplo abaixo.

Exemplo de Entrada	            Exemplo de Saída

400.00                          Novo salario: 460.00
                                Reajuste ganho: 60.00
                                Em percentual: 15 %

800.01                          Novo salario: 880.01
                                Reajuste ganho: 80.00
                                Em percentual: 10 %

2000.00                         Novo salario: 2140.00
                                Reajuste ganho: 140.00
                                Em percentual: 7 % 
*/

double salario, reajuste = 0, acrescimo, percentual, salarioFinal;

Console.WriteLine("Informe o salário do funcionário:");    
salario = double.Parse(Console.ReadLine());

if (salario <= 400.0)
{
    reajuste = 1.15;
}

else if (salario <= 800.0)
{
    reajuste = 1.12;
}
else if (salario <= 1200.0)
{
    reajuste = 1.10;
}
else if (salario <= 2000.0)
{
    reajuste = 1.07;
}
else
{
    reajuste = 1.04;
}

salarioFinal = salario * reajuste;
acrescimo = salarioFinal - salario;
percentual = (reajuste - 1) * 100;

Console.WriteLine("Novo salario: " + salarioFinal.ToString("F2"));
Console.WriteLine("Reajuste ganho: " + acrescimo.ToString("F2"));
Console.WriteLine("Em percentual: " + percentual.ToString("F0") + " %");
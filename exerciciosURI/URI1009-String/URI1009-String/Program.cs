/*
Salário com Bônus

Faça um programa que leia o nome de um vendedor, o seu salário fixo e o total de vendas efetuadas por ele 
no mês (em dinheiro). Sabendo que este vendedor ganha 15% de comissão sobre suas vendas efetuadas, informar 
o total a receber no final do mês, com duas casas decimais.

Entrada

O arquivo de entrada contém um texto (primeiro nome do vendedor) e 2 valores de dupla precisão (double) com 
duas casas decimais, representando o salário fixo do vendedor e montante total das vendas efetuadas por este 
vendedor, respectivamente.

Saída

Imprima o total que o funcionário deverá receber, conforme exemplo fornecido.

Exemplos de Entrada	e de Saída

Entrada:
JOAO
500.00
1230.30

Saída:
TOTAL = R$ 684.54

Entrada:
PEDRO
700.00
0.00

Saída:
TOTAL = R$ 700.00

Entrada:
MANGOJATA
1700.00
1230.50

Saída:
TOTAL = R$ 1884.58
*/

string nome;
double salarioFixo, totalVendas, salarioTotal;

Console.WriteLine("informe o nome do vendedor(a):");
nome = Console.ReadLine();

Console.WriteLine("informe o valor do salário fixo do vendedor(a):");
salarioFixo = double.Parse(Console.ReadLine());

Console.WriteLine("informe o valor taltal em vendas do vendedor(a):");
totalVendas = double.Parse(Console.ReadLine());

salarioTotal = totalVendas * 15 / 100 + salarioFixo;

Console.WriteLine("TOTAL = R$ " + salarioTotal.ToString("F2"));

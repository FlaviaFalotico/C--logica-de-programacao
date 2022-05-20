/*
                                    Lanche

Com base na tabela abaixo, escreva um programa que leia o código de um item e a 
quantidade deste item. A seguir, calcule e mostre o valor da conta a pagar.

            CÓDIGO      ESPECIFICAÇÃO       PREÇO
               1       Cachorro Quente      R$4,00
               2           X-Salada         R$4,50
               3           X-Bacon          R$5,00
               4       Torrada Simples      R$2,00
               5         Refrigerante       R$1,50

Entrada
O arquivo de entrada contém dois valores inteiros correspondentes ao código e à 
quantidade de um item conforme tabela acima.

Saída
O arquivo de saída deve conter a mensagem "Total: R$ " seguido pelo valor a ser 
pago, com 2 casas após o ponto decimal.

Exemplo de Entrada	Exemplo de Saída

3 2                 Total: R$ 10.00

4 3                 Total: R$ 6.00

2 3                 Total: R$ 13.50
*/

Console.Write("Informe o código do produto e a quantidade desejada: ");

string[] valores = Console.ReadLine().Split(' ');
int codigo = int.Parse(valores[0]);
int quantidade = int.Parse(valores[1]);

double total;

if (codigo == 1)
{
    total = quantidade * 4.0;
}
else if (codigo == 2)
{
    total = quantidade * 4.5;
}
else if (codigo == 3)
{
    total = quantidade * 5.0;
}
else if (codigo == 4)
{
    total = quantidade * 2.0;
}
else
{
    total = quantidade * 1.5;
}

Console.WriteLine("Total: R$ " + total.ToString("F2"));


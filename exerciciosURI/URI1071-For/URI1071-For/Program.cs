/*
Soma de Impares Consecutivos I

Leia 2 valores inteiros X e Y. A seguir, calcule e mostre a soma dos números impares entre eles.

Entrada
O arquivo de entrada contém dois valores inteiros.

Saída
O programa deve imprimir um valor inteiro. Este valor é a soma dos valores ímpares que estão entre 
os valores fornecidos na entrada que deverá caber em um inteiro.

Exemplo de Entrada	Exemplo de Saída

 6                  5
-5

15                  13
12

12                  0
12
*/

int x, y, valorMin, ValorMax, soma;

//Leitura dos valores digitados pelo usuário.
x = int.Parse(Console.ReadLine());
y = int.Parse(Console.ReadLine());

//Como os valores digitados podem iniciar com números negativos ou positivos, foi necessário
//declarar as variáveis de valor máximo e valor mínimo para as duas situações possíveis:
//x = valor mínimo e y = valor máximo;
//y = valor mínimo e y x = valor máximo.
if (x < y)
{
    valorMin = x;
    ValorMax = y;
}
else
{
    valorMin = y;
    ValorMax = x;
}

//i foi iniciada com valor mínimo + 1, pois os valores limites não entram na contagem. Pelo mesmo motivo,
//a condição pede que i seja menor que o valor máximo. Dentro da estrutura de repetição, devemos garantir 
//que apenas os números ímpares sejam contados e somados, sejam eles negativos ou positivos.
soma = 0;
for (int i = valorMin + 1; i < ValorMax; i++)  
{
    if (i % 2 != 0) // Para cada valor da variável i testaremos se o valor é ímpar, em caso positivo, o valor de i entrará na soma.
    {
        soma = soma + i;
    }
}
//Essa estrutura é externa à estrutura de repetição, pois só apresentamos o resultado quando a condição
//não é mais satisfeita, ou seja, saindo da mesma.
Console.WriteLine(soma);
/*
Soma de Impares Consecutivos I

Leia 2 valores inteiros X e Y. A seguir, calcule e mostre a soma dos números impares entre eles.

Entrada
O arquivo de entrada contém dois valores inteiros.

Saída
O programa deve imprimir um valor inteiro. Este valor é a soma dos valores ímpares que estão entre
os valores fornecidos na entrada que deverá caber em um inteiro.

Exemplo de Entrada	Exemplo de Saída
         6                 5
        -5

        15                13
        12
               
        12                 0
        12
*/

/// <summary>
/// Declaração das variáveis que serão informadas pelo usuário, X e Y.
/// Declaração das variáveis que receberão o menor e o maior valor digitados pelo usuário, MinValor e MaxValor.
/// </summary>
int X, Y, MinValor, MaxValor, soma;

/// <summary>
/// Leitura de dois valores inteiros, positivos ou negativos, informados pelo usuário.
/// </summary>
Console.Write("Informe um valor inteiro, positivo ou negativo: ");
X = int.Parse(Console.ReadLine());
Console.Write("Informe um segundo valor inteiro, positivo ou negativo: ");
Y = int.Parse(Console.ReadLine());

/// <summary>
/// Condicionais que alocam o menor e o maior valor de acordo com o informado pelo usuário.
/// </summary>
if (X > Y)
{
    MinValor = Y;
    MaxValor = X;
}
else
{
    MinValor = X;
    MaxValor = Y;
}

/// <summary>
/// A variável i é inciada um núemro após o valor mínimo informado e a condição é que i seja 
/// menor que o valor máximo, vez que, os valores das extremidades, conforme o exemplo, não 
/// fazem parte da soma.
/// </summary>
soma = 0;
for( int i = MinValor + 1; i < MaxValor; i++ )
{
    if (i % 2 != 0) //condicição para que apenas os números pares entre os valores informados sejam informados.
    {
        soma = soma + i;
    }
}
Console.WriteLine($"O valor da soma dos números inteiros negativos é de: {soma}");

//Adaptação:

int A, B, Min, Max, somaImpar;
char resposta = ' ';

Console.WriteLine("Começa aqui!");
do
{
    Console.Clear();
    Console.Write("Informe um valor inteiro, positivo ou negativo: ");
    A = int.Parse(Console.ReadLine());
    Console.Write("Informe um segundo valor inteiro, positivo ou negativo: ");
    B = int.Parse(Console.ReadLine());
    
    if (A > B)
    {
        Min = B;
        Max = A;
    }
    else
    {
        Min = A;
        Max = B;
    }

    somaImpar = 0;
    for (int i = MinValor + 1; i < MaxValor; i++)
    {
        if (i % 2 != 0)
        {
            somaImpar = somaImpar + i;
        }
    }
    Console.WriteLine($"O valor da soma dos números inteiros negativos é de: {somaImpar}");

    Console.Write("Deseja continuar (S/N)?");
    resposta = char.Parse(Console.ReadLine().ToUpper());
    if (resposta != 'S' || resposta != 'N')
    {
        Console.WriteLine("opção inválida!");
        Console.Write("Deseja continuar (S/N)?");
        resposta = char.Parse(Console.ReadLine().ToUpper());
    }
    Console.ReadKey();

} while (resposta == 'S');
/*
Fazer um programa para ler um número inteiro positivo N, depois ler N números
quaisquer e armazená-los em um vetor. Em seguida, mostrar na tela todos
elementos do vetor.

Entrada         Saída
4               10.5
10.5             4.2
4.2             -7.1
-7.1             5.0
15.0
*/
using System.Globalization; //Para aceitar o ponto como separador de decimais.

int N = int.Parse(s: Console.ReadLine()); //valor da variável N

//declaração e instanciação do vetor denominado vet
double[] vet = new double[N]; // o vetor tem tamanho N

// Recebe as posições do vetor de tamanho N, nesse exemplo, 4 posições {0, 1, 2, 3}.
for (int i = 0; i < N; i++)
{
    vet[i] = double.Parse(s: Console.ReadLine(), CultureInfo.InvariantCulture); //Para aceitar o ponto como separador de decimais.
}

//Para exibir os números alocados no vetor
for (int i = 0; i < N; i++)
{
    Console.WriteLine(vet[i].ToString("F1", CultureInfo.InvariantCulture));
}
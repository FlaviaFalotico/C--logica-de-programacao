/*
Faça um programa para ler um número indeterminado de dados contendo cada um a idade de um indivíduo

O último dado que não entrará nos cálculos contém um valor de idade negativa.

Calcular imprimir a idade média desse grupo de indivíduos se for entrar num valor negativo na primeira

vez mostrará a mensagem "impossível calcular".

Exemplos

Entrada         Saída
31              34,67
27
46
-5

-10             impossível calcular
*/

Console.Write("Digite uma idade: ");
double idade = double.Parse(Console.ReadLine());

double media, soma = 0.0;
int cont = 0;

while (idade >= 0)
{
    soma = soma + idade;
    cont = cont + 1;
    Console.Write("Digite uma idade: ");
    idade = double.Parse(Console.ReadLine());
}
if (cont == 0)
{
    Console.WriteLine("impossível calcular");
}
else
{
    media = soma / cont;
    Console.Write($"A média das idades informadas é de: {media.ToString("F2")}.");
}
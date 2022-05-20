/*
Uma operadora de telefonia cobra R$50,00 por um plano básico que dá direito a 100 minutos de telefone.

Cada minuto que exceder a franquia de 100 minutos custa R$2,00.

Fazer um programa para ler a quantidade de minutos que uma pessoa consumiu daí mostrar o valor a ser pago. 

Exemplos de Entrada     Exemplos de Saída

22                      Valor a pagar: R$50,00

103                     Valor a pagar: R$56,00
*/

int minutos, minutosExcedentes;
double tarifaFranquia = 50.00, tarifaExcedente = 2.00, valorConta = 0;

Console.Write("Informe a quantidades de minutos consumidos: ");
minutos = int.Parse(Console.ReadLine());

if (minutos <= 100)
{
    Console.WriteLine("Valor a pagar: R$" + tarifaFranquia.ToString("F2"));
}
else
{
    minutosExcedentes = minutos - 100;
    valorConta = tarifaFranquia + (minutosExcedentes * tarifaExcedente);

    Console.WriteLine("Valor a pagar: R$" + valorConta.ToString("F2"));
}

//Resolução do Professor Nélio:
int minutos;
double conta;

minutos = int.Parse(Console.ReadLine());

conta = 50.0;
if (minutos > 100)
{
    conta += (minutos - 100) * 2.0;// é a mesma coisa que: conta = conta + (minutos - 100) * 2.0;
}

Console.WriteLine("Valor a pagar: R$" + conta.ToString("F2"));
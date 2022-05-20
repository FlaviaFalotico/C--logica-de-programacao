/**
Conversão de Tempo

Leia um valor inteiro, que é o tempo de duração em segundos de um determinado 
evento em uma fábrica, e informe-o expresso no formato horas:minutos:segundos.

Entrada
O arquivo de entrada contém um valor inteiro N.

Saída
Imprima o tempo lido no arquivo de entrada (segundos), convertido para horas:
minutos:segundos, conforme exemplo fornecido.

Exemplo de Entrada e Saída

Entrada:
556
Saída:
0:9:16

Entrada:
1
Saída:
0:0:1

Entrada:
140153
Saída:
38:55:53

ANÁLISE:
1 minuto = 60 segundos
1 hora = 60 minutos = 3600 segundos

140153 segundos contém quantas horas?

140153 / 3600 = 38,931388...

38 x 3600 = 136800
SOBRA: 3353

3353 / 60 = 55,8833...
55 x 60 = 3300
SOBRA: 53

Aplicaremos: 

• Operador % ("mod")
*/

int N, horas, minutos, segundos, resto;

Console.WriteLine("Informe o valor em segundos que deseja converter para o formato horas:minutos:segundos:");
N = int.Parse(Console.ReadLine());

horas = N / 3600;
resto = N % 3600;

minutos = resto / 60;
segundos = resto % 60;

Console.WriteLine(horas + ":" + minutos + ":" + segundos);
/*
Tempo de Jogo com Minutos

Leia a hora inicial, minuto inicial, hora final e minuto final de um jogo. A seguir calcule a duração do jogo.

Obs: O jogo tem duração mínima de um (1) minuto e duração máxima de 24 horas.

Entrada
Quatro números inteiros representando a hora de início e fim do jogo.

Saída
Mostre a seguinte mensagem: “O JOGO DUROU XXX HORA(S) E YYY MINUTO(S)” .

Exemplo de Entrada	Exemplo de Saída

7 8 9 10            O JOGO DUROU 2 HORA(S) E 2 MINUTO(S)

7 7 7 7             O JOGO DUROU 24 HORA(S) E 0 MINUTO(S)

7 10 8 9            O JOGO DUROU 0 HORA(S) E 59 MINUTO(S) 
*/

int horaInicial, minutoInicial, horaFinal, minutoFinal, instanteInicial, instanteFinal, duracao, duracaoHoras, duracaoMinutos;

Console.WriteLine("Informe a seguir quatro valores, hora e minuto incial do jogo e hora e minuto final do jogo: ");
string[] valores = Console.ReadLine().Split(' ');
horaInicial = int.Parse(valores[0]);
minutoInicial = int.Parse(valores[1]);
horaFinal = int.Parse(valores[2]);
minutoFinal = int.Parse(valores[3]);

/// <summary>
/// Primeiramente, multiplicamos a hora inicial por 60 para converter para minutos e, depois, somamos com o minuto inicial.
/// Realizamos o mesmo processo para obtermos os intantes finais.
/// </summary>
instanteInicial = horaInicial * 60 + minutoInicial;
instanteFinal = horaFinal * 60 + minutoFinal;

if (instanteInicial < instanteFinal)
{
    duracao = instanteFinal - instanteInicial;
}
else
{
    duracao = (24 * 60 - instanteInicial) + instanteFinal;
}

/// <summary>
/// Para saber a a duração em horas do jogo utilizamos a parte inteira da divisão da duração total em minutos por 60.
/// Enquanto isso, a duração em minutos é dada pelo resto da divisão entre a duração total em minutos por 60.
/// </summary>
duracaoHoras = duracao / 60;
duracaoMinutos = duracao % 60;

Console.WriteLine("O JOGO DUROU " + duracaoHoras + " HORA(S) E " + duracaoMinutos + " MINUTO(S)");
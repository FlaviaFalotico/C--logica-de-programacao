﻿/*
Média 3

Leia quatro números (N1, N2, N3, N4), cada um deles com uma casa decimal, correspondente às quatro notas de um aluno. 
Calcule a média com pesos 2, 3, 4 e 1, respectivamente, para cada uma destas notas e mostre esta média acompanhada pela 
mensagem "Media: ". 
Se esta média for maior ou igual a 7.0, imprima a mensagem "Aluno aprovado.". Se a média calculada for 
inferior a 5.0, imprima a mensagem "Aluno reprovado.". Se a média calculada for um valor entre 5.0 e 6.9, inclusive estas, 
o programa deve imprimir a mensagem "Aluno em exame.".

No caso do aluno estar em exame, leia um valor correspondente à nota do exame obtida pelo aluno. Imprima então a mensagem 
"Nota do exame: " acompanhada pela nota digitada. Recalcule a média (some a pontuação do exame com a média anteriormente 
calculada e divida por 2). e imprima a mensagem "Aluno aprovado." (caso a média final seja 5.0 ou mais ) ou "Aluno reprovado.", 
(caso a média tenha ficado 4.9 ou menos). Para estes dois casos (aprovado ou reprovado após ter pego exame) apresente na última 
linha uma mensagem "Media final: " seguido da média final para esse aluno.

Entrada
A entrada contém quatro números de ponto flutuante correspendentes as notas dos alunos.

Saída
Todas as respostas devem ser apresentadas com uma casa decimal. As mensagens devem ser impressas conforme a descrição do problema. 
Não esqueça de imprimir o enter após o final de cada linha, caso contrário obterá "Presentation Error".

Exemplo de Entrada	Exemplo de Saída

2.0 4.0 7.5 8.0     Media: 5.4
6.4                 Aluno em exame.
                    Nota do exame: 6.4
                    Aluno aprovado.
                    Media final: 5.9

2.0 6.5 4.0 9.0     Media: 4.8
                    Aluno reprovado.

9.0 4.0 8.5 9.0     Media: 7.3
                    Aluno aprovado.

Obs.: Na média ponderada dividimos pela soma dos pesos.
*/
/// <summary>
/// Armazenam, respectivamente as quatro notas, a media ponderada das notas e, caso necessário, a nota obtida no exame e a média final do aluno.
/// </summary>
float N1, N2, N3, N4, media, notaExame = 0, mediaFinal = 0;

Console.WriteLine("Informe as quatro notas obtidas: ");
/// <summary>
/// Recebe as quatro notas obtidas pelo aluno.
/// </summary>
string[] notas = Console.ReadLine().Split(" ");
N1 = float.Parse(notas[0]);
N2 = float.Parse(notas[1]);
N3 = float.Parse(notas[2]);
N4 = float.Parse(notas[3]);

/// <summary>
/// Cálculo da média ponderada das quatro notas, em que:
/// N1 tem peso 2;
/// N2 tem peso 3;
/// N3 tem peso 4;
/// N4 tem peso 1.
/// </summary>
media = (N1 * 2 + N2 * 3 + N3 * 4 + N4 * 1) / 10.0F;
Console.WriteLine("Media: " + media.ToString("F1"));

if (media >= 7.0)
{
    Console.WriteLine("Aluno aprovado.");
}
else if (media >= 5.0 && media <= 6.0)
{
    Console.WriteLine("Aluno em exame.");
    Console.WriteLine("Informe a nota obtida no exame:");
    notaExame = float.Parse(Console.ReadLine());
    Console.WriteLine("Nota do exame: " + notaExame.ToString("F1"));

    mediaFinal = (media + notaExame) / 2.0F;
    if (mediaFinal >= 5.0)
    {
        Console.WriteLine("Aluno aprovado.");
        Console.WriteLine("Media final: " + mediaFinal.ToString("F1"));
    }
    else
    {
        Console.WriteLine("Aluno reprovado.");
        Console.WriteLine("Media final: " + mediaFinal.ToString("F1"));
    }
}
else
{
    Console.WriteLine("Aluno reprovado.");
}
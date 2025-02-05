﻿/*
Validação de Nota

Faça um programa que leia as notas referentes às duas avaliações de um aluno. Calcule e imprima a média semestral. 
Faça com que o algoritmo só aceite notas válidas (uma nota válida deve pertencer ao intervalo [0,10]). 
Cada nota deve ser validada separadamente.

Entrada
A entrada contém vários valores reais, positivos ou negativos. 
O programa deve ser encerrado quando forem lidas duas notas válidas.

Saída
Se uma nota inválida  for lida, deve ser impressa a mensagem "nota invalida".
Quando duas notas válidas forem lidas, deve ser impressa a mensagem "media = " seguido do valor do cálculo. 
O valor deve ser apresentado com duas casas após o ponto decimal.

Exemplo de Entrada	Exemplo de Saída

-3.5                nota invalida
3.5                 
11.0                nota invalida
10.0               
                    media = 6.75
*/

double nota1, nota2, media = 0.0;

Console.WriteLine("Digite um valor, entre 0 e 10, para a nota 1:");
nota1 = double.Parse(Console.ReadLine());
do
{
    Console.WriteLine("nota invalida");
    Console.WriteLine("Digite um valor, entre 0 e 10, para a nota 1:");
    nota1 = double.Parse(Console.ReadLine());
} while (nota1 < 0.0 || nota1 > 10.0);

Console.WriteLine("Digite um valor, entre 0 e 10, para a nota 2:");
nota2 = double.Parse(Console.ReadLine());
do
{
    Console.WriteLine("nota invalida");
    Console.WriteLine("Digite um valor, entre 0 e 10, para a nota 2:");
    nota2 = double.Parse(Console.ReadLine());
} while (nota2 < 0.0 || nota2 > 10.0);

media = (nota1 + nota2) / 2.0;
Console.WriteLine($"media = {media.ToString("F2")}");
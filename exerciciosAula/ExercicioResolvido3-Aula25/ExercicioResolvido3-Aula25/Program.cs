/*
Fazer um programa para ler o nome (apenas uma palavra) e idade de duas pessoas.
Ao final mostrar uma mensagem com os nomes e a idade média entre essas pessoas,
com uma casa decimal, conforme exemplo.

Entrada: 

Maria 19
Joaquim 20

Saída:

A idade média de Maria e Joaquim é de 19.5 anos 
*/

string nome1, nome2;
int idade1, idade2;
double media;
string[] vet;

Console.WriteLine("Informa o primeiro nome e a idade de uma pessoa qualquer, separados por vírgula:");
vet = Console.ReadLine().Split(',');
nome1 = vet[0];
idade1 = int.Parse(vet[1]);

Console.WriteLine("Informa o primeiro nome e a idade de uma segunda pessoa qualquer, separados por vírgula:");
vet = Console.ReadLine().Split(',');
nome2 = vet[0];
idade2 = int.Parse(vet[1]);

media = (double)(idade1 + idade2) / 2.0;

Console.WriteLine("A idade média de " + nome1 + " e " + nome2 + " é de " + media.ToString("F1") + " anos");

Console.ReadLine();
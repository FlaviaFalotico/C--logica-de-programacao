/*
Múltiplos

Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" 
ou "Nao sao Multiplos", indicando se os valores lidos são múltiplos entre si.

Entrada
A entrada contém valores inteiros.

Saída
A saída deve conter uma das mensagens conforme descrito acima.

Exemplo de Entrada	Exemplo de Saída

6 24                Sao Multiplos

6 25                Nao sao Multiplos

Interpretação:

Para verificar se um número é múltiplo de outro, basta encontrar um número inteiro 
de modo que a multiplicação entre eles resulte no primeiro número. Exemplos: 

a) 35 é múltiplo de 7, pois 35 é igual a 7 multiplicado pelo número inteiro 5. 
b) 63 é múltiplo de 21, pois 63 é igual a 21 multiplicado pelo número inteiro 3.
*/

int A, B;

string[] valores = Console.ReadLine().Split(' ');
A = int.Parse(valores[0]);
B = int.Parse(valores[1]);

if(B % A == 0 || A % B == 0)
{
    Console.WriteLine("Sao Multiplos");
}
else
{
    Console.WriteLine("Nao sao Multiplos");
}
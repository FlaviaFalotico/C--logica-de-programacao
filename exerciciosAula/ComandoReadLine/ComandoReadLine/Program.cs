string frase, x, y, z;
  
frase = Console.ReadLine();
x = Console.ReadLine();
y = Console.ReadLine();
z = Console.ReadLine();
Console.WriteLine("Você digitou: ");
Console.WriteLine(frase);
Console.WriteLine(x);
Console.WriteLine(y);
Console.WriteLine(z);

//Solução para apresentar 3 palavras na mesma linha, armazenadas em três variáveis diferentes.
//string P1, P2, P3;

P1 = "batata";
P2 = "tomate";
P3 = "abacaxi";
Console.Write(P1 + " ");
Console.Write(P2 + " ");
Console.Write(P3 + " ");

//Split - é uma função que serve para recortar uma string em pedaços separados,
//de acordo com o caractere indicado entre paresenteses, nesse exemplo indicamos o espaço em branco.

string s = Console.ReadLine();
string[] vet = s.Split(' ');
string p1 = vet[0];
string p2 = vet[1];   
string p3 = vet[2];
Console.WriteLine(p1);
Console.WriteLine(p2);
Console.WriteLine(p3);

//Pode trocar a variável s (linha 27), diretamente pelo Console.ReadLine(), ficando assim:

//string[] vet = Console.ReadLine().Split(' ');
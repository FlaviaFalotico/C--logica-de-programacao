/*
Fazer um programa para ler um valor inteiro de 1 a 7 representando o dia da
semana (sendo 1=domingo 2=segunda e assim por diante). Escreva na tela o dia 
da semana correspondente conforme exemplos.

Exemplos de Entrada     Exemplos de Saída

1                       Dia da semana: domingo

4                       Dia da semana: quarta

9                       Dia da semana: valor inválido
*/

int x = int.Parse(Console.ReadLine());
string dia;

if (x == 1)
{
    dia = "domingo";
}
else if (x == 2)
{
    dia = "segunda";
}
else if (x == 3)
{
    dia = "terça";
}
else if (x == 4)
{
    dia = "quarta";
}
else if (x == 5)
{
    dia = "quinta";
}
else if (x == 6)
{
    dia = "sexta";
}
else if (x == 7)
{
    dia = "sábado";
}
else
{
    dia = "valor inválido";
}
Console.WriteLine("Dia da semana: " + dia);

//Utilizando a estrutura switch-case para o mesmo problema:

int x = int.Parse(Console.ReadLine());
string dia;

switch (x){
    case 1:
        dia = "domingo";
        break;
    case 2:
        dia = "segunda";
        break;
    case 3:
        dia = "terça";
        break;
    case 4:
        dia = "quarta";
        break;
    case 5:
        dia = "quinta";
        break;
    case 6:
        dia = "sexta";
        break;
    case 7:
        dia = "sábado";
        break;
    
    default:
        dia = "valor inválido";
        break;
}
Console.WriteLine("Dia da semana: " + dia);
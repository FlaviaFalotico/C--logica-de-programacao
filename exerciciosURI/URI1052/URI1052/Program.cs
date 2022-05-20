/*
Mês

Leia um valor inteiro entre 1 e 12, inclusive. Correspondente a este valor, deve ser 
apresentado como resposta o mês do ano por extenso, em inglês, com a primeira letra maiúscula.

Entrada
A entrada contém um único valor inteiro.

Saída
Imprima por extenso o nome do mês correspondente ao número 
existente na entrada, com a primeira letra em maiúscula.

Exemplo de Entrada	    Exemplo de Saída
4                       April 
*/

//Utilizando Switch-case:
string indiceMes;
string mes = "";

indiceMes = Console.ReadLine();

switch (indiceMes)
{
    case "1":
        mes = "January";
        break;
    case "2":
        mes = "February";
        break;
    case "3":
        mes = "March";
        break;
    case "4":
        mes = "April";
        break;
    case "5":
        mes = "May";
        break;
    case "6":
        mes = "June";
        break;
    case "7":
        mes = "July";
        break;
    case "8":
        mes = "August";
        break;
    case "9":
        mes = "September";
        break;
    case "10":
        mes = "October";
        break;
    case "11":
        mes = "November";
        break;
    case "12":
        mes = "December";
        break;
    default:
        Console.WriteLine("Mês inexistente!");
        break;
}
if (mes != "")
{
    Console.WriteLine(mes);
}

//Utilizando if-else:
int numero;

numero = int.Parse(Console.ReadLine());

if (numero >= 1 && numero <= 12)
{
    if (numero == 1)
    {
        Console.WriteLine("January");
    }
    else if (numero == 2)
    {
        Console.WriteLine("February");
    }
    else if (numero == 3)
    {
        Console.WriteLine("March");
    }
    else if (numero == 4)
    {
        Console.WriteLine("April");
    }
    else if (numero == 5)
    {
        Console.WriteLine("May");
    }
    else if (numero == 6)
    {
        Console.WriteLine("June");
    }
    else if (numero == 7)
    {
        Console.WriteLine("July");
    }
    else if (numero == 8)
    {
        Console.WriteLine("August");
    }
    else if (numero == 9)
    {
        Console.WriteLine("September");
    }
    else if (numero == 10)
    {
       Console.WriteLine("October");
    }
    else if (numero == 11)
    {
        Console.WriteLine("November");
    }
    else
    {
        Console.WriteLine("December");
    }
}

//Resolução Professor Nélio:
int m = int.Parse(Console.ReadLine());

if (m == 1)
{
    Console.WriteLine("January");
}
else if (m == 2)
{
    Console.WriteLine("February");
}
else if (m == 3)
{
    Console.WriteLine("March");
}
else if (m == 4)
{
    Console.WriteLine("April");
}
else if (m == 5)
{
    Console.WriteLine("May");
}
else if (m == 6)
{
    Console.WriteLine("June");
}
else if (m == 7)
{
    Console.WriteLine("July");
}
else if (m == 8)
{
    Console.WriteLine("August");
}
else if (m == 9)
{
    Console.WriteLine("September");
}
else if (m == 10)
{
    Console.WriteLine("October");
}
else if (m == 11)
{
    Console.WriteLine("November");
}
else
{
    Console.WriteLine("December");
}
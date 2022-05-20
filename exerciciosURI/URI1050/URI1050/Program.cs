/*
DDD

Leia um número inteiro que representa um código de DDD para discagem interurbana. 
Em seguida, informe à qual cidade o DDD pertence, considerando a tabela abaixo:

                            DDD  |  Destination
                          ----------------------
                            61   |  Brasilia
                            71   |  Salvador
                            21   |  Rio de Janeiro
                            11   |  Sao Paulo
                            32   |  Juiz de Fora
                            19   |  Campinas
                            27   |  Vitoria
                            31   |  Belo Horizonte

Se a entrada for qualquer outro DDD que não esteja presente na tabela acima, 
o programa deverá informar:

DDD nao cadastrado

Entrada
A entrada consiste de um único valor inteiro.

Saída
Imprima o nome da cidade correspondente ao DDD existente na entrada. Imprima DDD 
nao cadastrado caso não existir DDD correspondente ao número digitado.

Exemplo de Entrada	Exemplo de Saída

11                  Sao Paulo
*/

string indiceDdd;
string ddd = "";

indiceDdd = Console.ReadLine();

switch (indiceDdd)
{
    case "11":
        ddd = "Sao Paulo";
        break;
    case "19":
        ddd = "Campinas";
        break;
    case "21":
        ddd = "Rio de Janiro";
        break;
    case "27":
        ddd = "Vitoria";
        break;
    case "31":
        ddd = "Belo Horizonte";
        break;
    case "32":
        ddd = "Juiz de Fora";
        break;
    case "61":
        ddd = "Brasilia";
        break;
    case "71":
        ddd = "Salvador";
        break;
    default:
        Console.WriteLine("DDD nao cadastrado");
        break;
}
if (ddd != "")
{
    Console.WriteLine(ddd);
}
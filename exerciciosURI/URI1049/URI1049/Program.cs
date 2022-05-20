/*
Animal

Neste problema, você deverá ler 3 palavras que definem o tipo de animal possível segundo o esquema 
abaixo,da esquerda para a direita. Em seguida, conclua qual dos animais seguintes foi escolhido, 
através das três palavras fornecidas.

                            carnívoro   ____   águia
                   ave             
                            onívoro     ____   pomba          
vertebrado
                            onívoro     ____   homem   
                mamífero
                            herbívoro   ____   vaca                      

                            hemtófogo   ____   pulga
                 inseto         
                            herbívoro   ____   lagarta          
invertebrados
                            hemtófogo   ____   sanguessuga   
                anelídeo
                            onívoro     ____   minhoca                      

Entrada
A entrada contém 3 palavras, uma em cada linha, necessárias para identificar o animal segundo o esquema 
acima, com todas as letras minúsculas.

Saída
Imprima o nome do animal correspondente à entrada fornecida.

     Exemplos de Entrada	     Exemplos de Saída
     
     vertebrado                  homem
     mamifero
     onivoro
     
     vertebrado                  aguia
     ave
     carnivoro
       
     invertebrado               minhoca 
     anelideo
     onivoro       
*/

string grupo, filo, nutricao;

grupo = Console.ReadLine();
filo = Console.ReadLine();
nutricao = Console.ReadLine();

if (grupo == "vertebrado")
{
    if (filo == "ave")
    {
        if (nutricao == "carnivoro")
        {
            Console.WriteLine("aguia");
        }
        else
        {
            Console.WriteLine("pomba");
        }
    }
    else
    {
        if (nutricao == "onivoro")
        {
            Console.WriteLine("homem");
        }
        else
        {
            Console.WriteLine("vaca");
        }
    }
}
else
{
    if (filo == "inseto")
    {
        if (nutricao == "hemtofogo")
        {
            Console.WriteLine("pulga");
        }
        else
        {
            Console.WriteLine("lagarta");
        }
    }
    else
    {
        if (nutricao == "onivoro")
        {
            Console.WriteLine("minhoca");
        }
        else
        {
            Console.WriteLine("sanguessuga");
        }
    }
}
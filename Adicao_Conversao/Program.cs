using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adicao_Conversao
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             Para adicionar dois números, usaremos o operador de adição, que é o símbolo de mais +. Sim, o mesmo símbolo 
            de mais + que você usa para concatenação de cadeias de caracteres também é usado para adição. A reutilização 
            de um símbolo com várias finalidades é, às vezes, chamada de "sobrecarregar o operador", e ocorre f
            requentemente em C#.
            
            Neste caso, o compilador de C# entende o que você está tentando fazer. O compilador analisa o código e vê que 
            o + (operador) está posicionado entre dois valores numéricos (operandos). Dado os tipos de dados das variáveis 
            (ambos são ints), ele conclui que você deseja adicionar os dois valores.
             */

            int primeiroNumero = 12;
            int segundoNumero = 7;

            Console.WriteLine(primeiroNumero + segundoNumero);

            /*
             O que acontecerá se tentarmos usar o símbolo + com os valores string e int? Modifique o código escrito para que 
            corresponda ao código a seguir:
             */

            string primeiroNome = "Edi Junior";
            int widgetVendido = 7;

            Console.WriteLine(primeiroNome + " vendeu " + widgetVendido + " widgets.");

            /*
             Neste caso, o compilador de C# entende que queremos usar o símbolo + para concatenar os dois operandos. Ele deduz 
            isso porque o símbolo + está rodeado por operandos dos tipos de dados string e int. Sendo assim, ele tenta converter 
            implicitamente a variável int``widgetsSold em um string temporariamente, para que possa concatenar o restante da 
            cadeia de caracteres. O compilador de C# tenta ajudá-lo quando pode, mas o ideal é que você seja explícito quanto às 
            suas intenções.
             */

            /*
             Em vez de adicionar a variável int widgetsSold ao literal int 7, o compilador trata tudo como uma cadeia de caracteres 
            e concatena tudo.
             */

            string primeiroNome1 = "Edi Junior";
            int widgetVendido2 = 7;

            Console.WriteLine(primeiroNome1 + " vendeu " + widgetVendido2 + 7 + " widgets.");

            /*
             O símbolo de parêntese () se torna outro operador sobrecarregado. Neste caso, os parênteses de abertura e fechamento 
            formam o operador de ordem de operações, exatamente como você usaria em uma fórmula matemática. Indicamos que queremos 
            que o parêntese mais interno seja resolvido primeiro, resultando na adição de valores int``widgetsSold e no valor 7. 
            Após isso ser resolvido, ele converterá implicitamente o resultado em uma cadeia de caracteres para que possa ser 
            concatenado ao restante da mensagem.
             */

            string primeiroNome2 = "Edi Junior";
            int widgetVendido3 = 7;

            Console.WriteLine(primeiroNome2 + " vendeu " + (widgetVendido3 + 7) + " widgets.");
            Console.ReadLine();
        }
    }
}

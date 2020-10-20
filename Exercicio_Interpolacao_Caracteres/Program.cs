using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Interpolacao_Caracteres
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             A interpolação de cadeia de caracteres combina vários valores em uma única cadeia de caracteres 
            literal usando um "modelo" e uma ou mais expressões de interpolação. Uma expressão de interpolação 
            é uma variável cercada por um símbolo de chave de abertura e fechamento { }. A cadeia de caracteres 
            literal se torna um modelo quando ele é prefixado pelo caractere $.
             */

            string primeiroNome = "Edi Junior";
            string mensagem = $"Olá {primeiroNome}!";

            Console.WriteLine(mensagem);

            /*
             Você pode executar várias operações de interpolação na mesma linha de código.
             */

            string primeiroNome1 = "Edi Junior";
            string cumprimento = "Olá";
            string mensagem1 = $"{cumprimento} {primeiroNome1}!";

            Console.WriteLine(mensagem1);

            /*
             Da mesma forma que fizemos no exercício anterior, podemos eliminar a variável temporária para armazenar 
            a mensagem.
             */
            
            string primeiroNome2 = "Edi Junior";
            string cumprimento2 = "Olá";

            Console.WriteLine($"{cumprimento2} {primeiroNome2}!");

            /*
             Suponha que você precise usar um literal textual em seu modelo. Você pode usar o símbolo @ de prefixo 
            literal textual e o símbolo $ de interpolação de cadeia de caracteres juntos.
             */

            string nomeProjeto = "Primeiro-Projeto";

            Console.WriteLine($@"C:\Output\{nomeProjeto}\Data");
            Console.ReadLine();
        }
    }
}

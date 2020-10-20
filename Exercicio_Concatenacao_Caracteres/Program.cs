using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Concatenacao_Caracteres
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Para concatenar duas cadeias de caracteres, use o operador de concatenação de cadeia de caracteres, 
             que é o símbolo de adição +.
            */

            string primeiroNome = "Edi Junior";
            string mensagem = "Olá " + primeiroNome;
            
            Console.WriteLine(mensagem);

            /*
             Você pode executar várias operações de concatenação na mesma linha de código.
             */

            string primeiroNome2 = "Edi Junior";
            string cumprimento = "Olá";
            string mensagem2 = cumprimento + " " + primeiroNome2 + "!";
            
            Console.WriteLine(mensagem2);

            /*
            Usamos uma variável extra para conter a nova cadeia de caracteres resultante da operação de concatenação. 
            A menos que você tenha um bom motivo para fazer isso, você pode (e deve) evitar usar variáveis intermediárias 
            executando a operação de concatenação conforme necessário.
             */

            string primeiroNome3 = "Edi Junior";
            string cumprimento2 = "Olá";

            Console.WriteLine(cumprimento2 + " " + primeiroNome3 + "!");
            Console.ReadLine();
        }
    }
}

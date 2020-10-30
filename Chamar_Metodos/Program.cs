using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chamar_Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Como chamar métodos na Biblioteca de Classes do .NET
            Com base em sua experiência anterior com o método Console.WriteLine(), você já deve conhecer 
            os conceitos básicos:

            - Comece digitando o nome de classe, Console
            - Adicione o operador de acesso de membro, o símbolo .
            - Adicione o nome do método, WriteLine
            - Adicione o operador de invocação do método, que é um conjunto de parênteses ()
            - Por fim, adicione o valor que você deseja que o método Console.WriteLine() imprima como um 
            parâmetro de entrada entre os parênteses de abertura e de fechamento 
            (por exemplo, "Hello World!")
             */

            Console.WriteLine("Hello World!");

            /*
             O exemplo a seguir simula uma jogada de dados gerando um número aleatório e imprimindo-o no 
            console.

            Se você executar o código várias vezes, os números de 1 a 6 serão exibidos na saída do console.
             */

            Random falar = new Random();
            int lista = falar.Next(1, 7);
            Console.WriteLine(lista);

            /*
             Primeiro, vamos examinar o que cada linha de código realiza, vamos fazer algumas perguntas 
            importantes e algumas observações sobre como trabalhar com classes e métodos na Biblioteca de 
            Classes do .NET.
            
            A primeira linha de código cria uma instância da classe System.Random na Biblioteca de Classes 
            do .NET e armazena a referência ao novo objeto em uma variável denominada dice.
            
            A segunda linha de código chama o método Next() do objeto dice que passa dois parâmetros: o valor 
            mínimo e o máximo do número aleatório. O método Next() retorna o valor, que salvamos em uma 
            variável chamada roll.
            
            A terceira linha de código chama o método WriteLine() para imprimir o valor de roll no console.
            
            Neste exemplo de código, estamos chamando um método da classe Random e da classe Console. No 
            entanto, a maneira como estamos chamando esses métodos é diferente. O motivo pelo qual eles foram 
            chamados usando uma técnica diferente é porque alguns métodos são com estado e outros, sem estado.
             */

            Console.ReadLine();

        }
    }
}

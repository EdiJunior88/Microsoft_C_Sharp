using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Incrementar_Decrementar
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Frequentemente, você precisará incrementar e decrementar valores, especialmente ao trabalhar com lógicas de loop 
            ou com códigos que interajam com estruturas de dados que abriguem vários elementos de dados.

            O operador += adiciona e atribui o valor à direita do operador ao valor à esquerda do operador.

            O operador ++ incrementa em uma (1) unidade o valor da variável. Portanto, as linhas dois e três do seguinte 
            snippet de código são equivalentes:
             */

            int valor = 1;

            valor = valor + 1;
            Console.WriteLine("Primeiro Incremento: " + valor);

            valor += 1;
            Console.WriteLine("Segundo Incremento: " + valor);

            valor++;
            Console.WriteLine("Terceiro Incremento: " + valor);

            valor = valor - 1;
            Console.WriteLine("Primeiro Decremento: " + valor);

            valor -= 1;
            Console.WriteLine("Segundo Decremento: " + valor);

            valor--;
            Console.WriteLine("Terceiro Decremento: " + valor);

            /*
             Os operadores de incremento e decremento têm uma característica interessante – dependendo de sua posição, eles 
            executam sua operação antes ou depois de recuperarem o valor. Em outras palavras, se você usar o operador antes 
            do valor, como em ++value, o incremento ocorrerá antes que o valor seja recuperado. Da mesma forma, value++ 
            incrementará o valor após ele ser recuperado.
             */

            int value = 1;
            value++;

            Console.WriteLine("Primeiro: " + value);
            Console.WriteLine("Segundo: " + value++);
            Console.WriteLine("Terceiro: " + value);
            Console.WriteLine("Quarto: " + (++value));
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valores_Literais
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             Se quiséssemos apenas um único caractere alfanumérico 
            impresso na tela, poderíamos criar um literal char 
            circundando um caractere alfanumérico com aspas simples.
             */

            Console.WriteLine('b');

            /*
             Se quiser imprimir um valor numérico inteiro (sem frações) 
            na Saída, você poderá usar um literal int. Um literal int 
            não requer operadores adicionais, como o string ou char.
             */

            Console.WriteLine(123);

            Console.ReadKey(); //Fica aguardando pressionar alguma tecla para encerrar o console
        }
    }
}

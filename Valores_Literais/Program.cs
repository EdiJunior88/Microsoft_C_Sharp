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

            /*
             Se quiséssemos imprimir um número que inclui valores após o 
            ponto decimal, poderíamos usar um literal decimal.
            
            Para criar um literal decimal, acrescente a letra m após o 
            número. Nesse contexto, o m é chamado de sufixo literal. O 
            sufixo literal informa ao compilador que você deseja trabalhar 
            com um valor do tipo decimal.

            OBS.:
            Você pode usar um m em letras minúsculas ou um M em maiúsculas 
            como o sufixo literal para um decimal.
             */

            Console.WriteLine(12.3m);

            /*
             Se quiséssemos imprimir um valor representando true ou false, 
            poderíamos usar um literal bool.
             */

            Console.WriteLine(true);
            Console.WriteLine(false);

            /*
             É importante saber que esses valores podem se parecer com seus 
            literais de cadeias de caracteres equivalentes. Em outras palavras, 
            você pode achar que essas instruções são a mesma coisa:
            No entanto, isso é apenas a forma como elas são impressas na tela. 
            O fato é que os tipos de coisas que você pode fazer com o int ou 
            bool subjacente serão diferentes de seu string equivalente.
             */

            Console.WriteLine("123");
            Console.WriteLine(123);

            Console.WriteLine("true");
            Console.WriteLine(true);

            Console.ReadKey(); //Fica aguardando pressionar alguma tecla para encerrar o console
        }
    }
}

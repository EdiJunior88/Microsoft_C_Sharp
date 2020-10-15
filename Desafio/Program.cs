using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Neste desafio, você escreverá um código que combinará valores literais e 
             variáveis em uma única mensagem.

            Armazene os seguintes valores da saída em variáveis:

            - Bob
            - 3
            - 34.4
            
            Essas variáveis devem receber nomes que reflitam sua finalidade.

            Selecione o tipo de dados correto para cada uma das variáveis com base no tipo 
            de dados que ela manterá.

            Por fim, você combinará as variáveis com cadeias de caracteres literais passadas 
            para uma série de comandos Console.Write() para formar a mensagem completa.
             */

            String nome = "Bob";
            int numero = 3;
            decimal temperatura = 34.4m;

            Console.WriteLine("Olá, " + nome + "!" + " Você tem " + numero + " na sua caixa. " +
                "A tempeatura está medindo " + temperatura + " celsius.");

            Console.ReadLine();
        }
    }
}

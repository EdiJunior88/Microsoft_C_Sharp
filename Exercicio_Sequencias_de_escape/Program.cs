using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Sequencias_de_escape
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Suponha que o seu gerente tenha pedido que você crie um modelo de uma 
            ferramenta de linha de comando que vai gerar faturas em inglês e em 
            japonês. Você não precisa criar a funcionalidade real que gera as faturas
            ainda. Você só precisa fornecer a interface do usuário da linha de comando 
            para clientes internos no departamento de cobrança para aprovação. Seu 
            gerente pediu para você ter certeza de que adicionou formatação para tornar 
            claro o progresso atual da ferramenta. Seu gerente também pediu para fornecer 
            instruções para os usuários japoneses sobre como gerar faturas em japonês.
             */

            /*
             Uma sequência de caracteres de escape é uma instrução especial para o runtime 
            em que você deseja inserir um caractere especial que afetará a saída da cadeia 
            de caracteres. No C#, as sequências de caracteres de escape começam com uma 
            barra invertida \ e, em seguida, incluem outro caractere. Por exemplo, a 
            sequência \n adicionará uma nova linha e uma sequência \t adicionará uma guia.
             */

            Console.WriteLine("Hello\nWorld!");
            Console.WriteLine("Hello\tWorld!");
            Console.WriteLine("Hello \"World\"!");
            Console.WriteLine("c:\\source\\repos\\");
            Console.WriteLine("----------------------------------------------");

            /*
             Etapa 1 – Formatar a saída do aplicativo de linha de comando usando sequências de 
            escape de caractere. Para criar o modelo de nossa ferramenta de linha de comando, 
            adicione o código a seguir no editor.
             */

            Console.WriteLine("Gerando faturas para o cliente \"ABC Corp\" ...\n");
            Console.WriteLine("Fatura: 1021\t\tCompleta!");
            Console.WriteLine("Fatura: 1022\t\tCompleta!");
            Console.WriteLine("\nDiretório:\t");
            Console.WriteLine("----------------------------------------------");

            /*
             Literal de cadeia de caracteres textual
            Um literal de cadeia de caracteres textual manterá todo o espaço em branco e os 
            caracteres sem a necessidade de escapar da barra invertida. Para criar uma cadeia
            de caracteres textual, use a diretiva @ antes da cadeia de caracteres literal.
             */

            Console.WriteLine(@"    c:\source\repos 
            (é para onde seu código vai)");
            Console.WriteLine("----------------------------------------------");

            /*
             Etapa 2 – Formatar a saída do aplicativo de linha de comando usando uma cadeia de 
            caracteres textual. 
            Adicione a seguinte linha de código abaixo do código que foi adicionado na etapa 1.
             */

            Console.WriteLine("Gerando faturas para o cliente \"ABC Corp\" ...\n");
            Console.WriteLine("Fatura: 1021\t\tCompleta!");
            Console.WriteLine("Fatura: 1022\t\tCompleta!");
            Console.WriteLine("\nDiretório:\t");
            Console.WriteLine(@"c:\faturas\");
            Console.WriteLine("----------------------------------------------");

            /*
             Caracteres de escape Unicode
            Você também pode adicionar caracteres codificados em cadeias de caracteres literais 
            usando a sequência de escape \u e, em seguida, um código de quatro caracteres 
            representando algum caractere em Unicode (UTF-16).

             Observação
            Existem várias advertências. Primeiro, alguns consoles, como o prompt de comando do 
            Windows, não exibirão todos os caracteres Unicode. Ele substituirá esses caracteres 
            por caracteres de ponto de interrogação. Além disso, os exemplos usados aqui são 
            UTF-16. Alguns caracteres exigem UTF-32 e, portanto, exigem uma sequência de escape 
            diferente. Esse é um assunto complicado, e este módulo pretende apenas mostrar o que 
            é possível. Dependendo de sua necessidade, talvez seja necessário gastar bastante 
            tempo aprendendo e trabalhando com caracteres Unicode em seus aplicativos.
             */

            //Kon'nichiwa World
            Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");
            Console.WriteLine("----------------------------------------------");

            /*
             Etapa 3 – Formatar a saída do aplicativo de linha de comando usando caractere de escape 
            Unicode
            Para concluir a interface do usuário de linha de comando fictícia, vamos adicionar uma 
            frase em japonês, traduzida como "para gerar faturas em japonês" e fornece uma cadeia de 
            caracteres literal textual com o executável do aplicativo com um sinalizador. Também 
            adicionaremos algumas sequências de escape para formatação.
             */

            Console.WriteLine("Gerando faturas para o cliente \"ABC Corp\" ...\n");
            Console.WriteLine("Fatura: 1021\t\tCompleta!");
            Console.WriteLine("Fatura: 1022\t\tCompleta!");
            Console.WriteLine("\nDiretório:\t");

            //Para gerar faturas em japonês
            //Nihon no seikyū-sho o seisei suru ni wa
            Console.WriteLine("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
            Console.WriteLine(@"c:\faturas\app.exe -j");
            Console.ReadLine();
        }
    }
}

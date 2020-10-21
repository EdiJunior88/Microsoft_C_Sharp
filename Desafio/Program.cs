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
             Neste desafio, você imprimirá instruções para o usuário final para que ele saiba onde seu aplicativo 
            gerará arquivos de dados. Na verdade, não vamos criar nenhum arquivo. Estamos interessados apenas em 
            exibir instruções formatadas na janela do console. 
            
            Você usará o que aprendeu sobre sequências de escape de caractere, cadeias de caracteres textuais, 
            Unicode e interpolação de cadeias para fornecer instruções em inglês e russo.
             */

            /*
             Em outras palavras, para concluir esse desafio, você só pode criar duas instruções que realmente 
            imprimem a saída no console. Se você precisar imprimir novas linhas adicionais ou adicionar qualquer 
            formatação, deverá usar o que aprendeu neste módulo para realizar a tarefa.
             */

            string nomeProjeto = "ACME";
            string mensagemRussa = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

            Console.WriteLine($@"View English output:
        c:\Exercise\{nomeProjeto}\data.txt");
            Console.WriteLine();
            Console.WriteLine($@"{mensagemRussa}:
        c:\Exercise\{nomeProjeto}\ru-RU\data.exe");
            Console.ReadLine();
        }
    }
}

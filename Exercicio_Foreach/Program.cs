using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Exercício – Instrução foreach
            
            Imagine que você trabalha para uma fábrica e precisa fazer um inventário do depósito para determinar o número atual 
            de produtos finais que estão prontos para o envio. Além do número total de produtos finais, você também pode querer 
            imprimir uma contagem e o total atual de cada compartimento individual do depósito em que os produtos finais são 
            armazenados. Imprimir esse total atual criaria uma trilha de auditoria para verificar novamente o trabalho e 
            identificar reduções.

            Executar um loop em uma matriz usando o foreach
            
            A instrução foreach realiza um loop em cada elemento da matriz, executando o bloco de código abaixo da declaração e 
            substituindo o valor em uma variável temporária pelo valor da matriz representada pelo loop atual.
             */

            string[] nomes =
            {
                "Bob",
                "Conrad",
                "Grant"
            };

            foreach(string nome in nomes)
            {
                Console.WriteLine(nome);
            }

            Console.ReadLine();
        }
    }
}

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
             Neste exercício, você usará o IntelliSense ou o docs.microsoft.com para localizar e chamar 
            um método que retorna o maior de dois números.

            Etapa 2: Use um método da classe System.Math para determinar qual dos dois números é maior.

            Seu trabalho é pesquisar e preencher a linha de código ausente que chama um método da 
            classe Math que aceitará dois valores e retornará o maior deles na variável largerValue, 
            que será impressa no console.

            Para fazer isso, use um método na classe System.Math. É possível usar o IntelliSense ou o 
            docs.microsoft.com para encontrar o método e descobrir como chamá-lo corretamente.
             */

            int primeiroValor = 500;
            int segundoValor = 600;
            int maiorValor;

            maiorValor = Math.Max(primeiroValor, segundoValor);

            Console.WriteLine(maiorValor);

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valores_Retornados
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             Muitos métodos na Biblioteca de Classes do .NET têm assinaturas de método sobrecarregado.
            
            Um método sobrecarregado é definido com várias assinaturas de método. Os métodos 
            sobrecarregados oferecem diferentes maneiras de chamar o método ou diferentes tipos de dados.
            
            Em alguns casos, versões sobrecarregadas de um determinado método permitem que você envie 
            valores de tipos de dados diferentes para o método. Por exemplo, o método Console.WriteLine() 
            tem 19 versões sobrecarregadas diferentes. A maioria dessas sobrecargas permite que você envie 
            diferentes tipos de dados que deseja imprimir no console. Considere o seguinte código:
             */

            int numero = 7;
            string texto = "sete";

            Console.WriteLine(numero);
            Console.WriteLine();
            Console.WriteLine(texto);

            /*
             Em outros casos, as versões sobrecarregadas de um determinado método permitem que você envie 
            detalhes de configuração adicionais para o método sobre o resultado desejado. Por exemplo, o 
            método Random.Next() tem três versões sobrecarregadas diferentes. As três versões permitem que
            você defina restrições sobre o número gerado aleatoriamente.
            
            O exemplo de código a seguir chama o Random.Next() usando três versões sobrecarregadas diferentes:
             */

            Random dados = new Random();
            int lista1 = dados.Next();
            int lista2 = dados.Next(101);
            int lista3 = dados.Next(50, 101);

            Console.WriteLine($"Primeira Lista: {lista1}");
            Console.WriteLine($"Segunda Lista: {lista2}");
            Console.WriteLine($"Terceira Lista: {lista3}");

            /*
             A primeira versão do método Next() não define um limite superior e inferior; portanto, o método 
            retornará valores que variam de 0 a 2,147,483,647, que é o valor máximo que um int pode armazenar.
            
            A segunda versão do método Next() especifica o valor máximo como um limite superior. Portanto, 
            nesse caso, podemos esperar um valor aleatório entre 0 e 100.
            
            A terceira versão do método Next() especifica os valores mínimo e máximo. Portanto, nesse caso, 
            podemos esperar um valor aleatório entre 50 e 100.
             */

            Console.ReadLine();
        }
    }
}

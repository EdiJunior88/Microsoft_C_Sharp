using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Declarar matrizes
            
            Uma matriz é um tipo especial de variável que pode conter vários valores do mesmo tipo de dados. 
            A sintaxe da declaração é ligeiramente diferente porque é necessário especificar o tipo de dados 
            e o tamanho da matriz.
             */

            // string[] ordemIDFraudulento = new string[3];

            /*
             Atribuir valores a elementos de uma matriz

            Já declaramos uma matriz de cadeias de caracteres, mas todos os elementos dela estão vazios. Para 
            acessar um elemento de uma matriz, use um índice numérico baseado em zero dentro de colchetes.

            Atribua um valor usando o valor de atribuição = como se fosse uma variável normal.
             */

            /*
            ordemIDFraudulento[0] = "A123";
            ordemIDFraudulento[1] = "B456";
            ordemIDFraudulento[2] = "C789";
            ordemIDFraudulento[3] = "D000";
            */

            /*
             Obter valores de elementos em uma matriz
            
            Use o mesmo processo para obter o valor de um elemento em uma matriz. Use o índice do elemento 
            para recuperar seu valor.
             */

            /*
            Console.WriteLine($"Primeiro: {ordemIDFraudulento[0]}");
            Console.WriteLine($"Segundo: {ordemIDFraudulento[1]}");
            Console.WriteLine($"Terceiro: {ordemIDFraudulento[2]}");
            */

            /*
             Etapa 5: Reatribuir o valor de uma matriz

            Os elementos de uma matriz são como qualquer outro valor de variável, de modo que você pode atribuir, 
            recuperar e reatribuir um valor a cada elemento da matriz.

            Adicione as seguintes linhas de código ao fim do Editor do .NET. Aqui, você reatribuirá o valor do 
            primeiro elemento na matriz e, em seguida, imprimirá ele.
             */

            /*
            ordemIDFraudulento[0] = "F000";

            Console.WriteLine($"Primeiro Atualizado: {ordemIDFraudulento[0]}");
            */

            string[] ordemIDFraudulento =
            {
                "A123",
                "B456",
                "C789"
            };

            Console.WriteLine($"Primeiro: {ordemIDFraudulento[0]}");
            Console.WriteLine($"Segundo: {ordemIDFraudulento[1]}");
            Console.WriteLine($"Terceiro: {ordemIDFraudulento[2]}");

            ordemIDFraudulento[0] = "F000";

            Console.WriteLine($"Primeiro Atualizado: {ordemIDFraudulento[0]}");

            /*
             Obter o tamanho de uma matriz
            
            Dependendo de como a matriz é criada, talvez você não saiba com antecedência quantos elementos ela contém. 
            Para determinar o tamanho de uma matriz, você pode usar a propriedade Length.
             */

            Console.WriteLine($"Existem {ordemIDFraudulento.Length} processos de ordem fraudulentos.");

            Console.ReadLine();
        }
    }
}

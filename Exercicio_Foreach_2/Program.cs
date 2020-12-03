using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Foreach_2
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             Etapa 1: Criar e inicializar uma matriz de int

            Etapa 2: Adicionar uma instrução foreach para iterar na matriz
            
            Em seguida, adicione uma instrução foreach que itera em cada elemento da matriz inventory, atribuindo temporariamente o 
            valor do elemento atual à variável items. Seu código deve corresponder à listagem a seguir.

            Etapa 3: Adicionar uma variável para somar o valor de cada elemento na matriz
            
            Defina uma nova variável que representa a soma de todos os produtos finais no depósito. Não se esqueça de adicioná-la 
            fora da instrução foreach.

            Dentro da instrução foreach, adicione a seguinte linha de código, que acrescenta o valor atual armazenado em items à 
            variável sum.

            Etapa 4: Exibir o valor final da soma
            
            Abaixo do bloco de código da instrução foreach, adicione a seguinte instrução que imprime a soma final de itens no 
            inventário.
             */

            int[] inventario =
            {
                200,
                450,
                700,
                175,
                250
            };

            int soma = 0;

            foreach (int itens in inventario)
            {
                soma += itens;
            }

            Console.WriteLine($"Nós temos {soma} itens no invetário.");
            Console.ReadLine();
        }
    }
}

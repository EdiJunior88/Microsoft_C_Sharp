using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Foreach_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Etapa 5 – Criar uma variável para armazenar o número do compartimento atual e exibir o total atual
            
            Para atender ao requisito final, é preciso criar uma variável para conter a iteração atual da instrução foreach. Desse modo, é possível exibir 
            o compartimento e a quantidade de itens finalizados dele junto com o total atual de todos os itens dos compartimentos contados até o momento.
            
            Acima da instrução foreach, declare e inicialize uma nova variável do tipo int para armazenar o número atual do compartimento cujo inventário 
            está sendo processado.
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
            int bin = 0;

            foreach (int itens in inventario)
            {
                soma += itens;
                bin++;
                Console.WriteLine($"Bin {bin} = {itens} itens (total de produtos: {soma})");
            }

            Console.WriteLine($"Nós temos {soma} itens no inventário.");
            Console.ReadLine();
        }
    }
}

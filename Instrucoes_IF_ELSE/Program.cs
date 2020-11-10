using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instrucoes_IF_ELSE
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             Etapa 1 – Usar a instrução if-else em vez de duas instruções if separadas
            
            Em vez de executar duas verificações para exibir a mensagem "Você venceu!" ou a mensagem "Sinto muito, 
            você perdeu, usaremos a palavra-chave else.
             */

            /* 
             Random dado = new Random();

             int rolar1 = dado.Next(1, 7);
             int rolar2 = dado.Next(1, 7);
             int rolar3 = dado.Next(1, 7);

             int total = rolar1 + rolar2 + rolar3;

             Console.WriteLine($"Dados rolados: {rolar1} + {rolar2} + {rolar3} = {total}");

             if ((rolar1 == rolar2) || (rolar2 == rolar3) || (rolar3 == rolar1))
             {
                 Console.WriteLine("Você rolou 2 dados iguais!    +2 bônus no total!");
                 total += 2;
             }

             if ((rolar1 == rolar2) && (rolar2 == rolar3))
             {
                 Console.WriteLine("Você rolou 3 dados iguais!    +6 bônus no total!");
                 total += 6;
             }

             if (total >= 15)
             {
                 Console.WriteLine("VOCÊ VENCEU!!!!");
             }
             else
             {
                 Console.WriteLine("Desculpe, Você perdeu!!!");
             }
            */

            /*
             Etapa 2 – Modificar o código para remover o bônus acumulado para resultados duplicados e triplicados usando aninhamento.
            
            Na unidade anterior, nós vimos que introduzimos um pequeno bug de lógica em nosso aplicativo. Vamos corrigi-lo usando 
            aninhamento.
            
            O aninhamento nos permite colocar blocos de código dentro de blocos de código. Neste caso, vamos aninhar uma instrução 
            if-else (a verificação de resultados triplicados) dentro de outra instrução if (a verificação de resultados duplicados) 
            para impedir que ambos aconteçam.
            
            Aninharemos a verificação de resultados triplicados dentro da verificação de duplicados. 
            */

            /*
            int rolar1 = 6;
            int rolar2 = 6;
            int rolar3 = 6;

            int total = rolar1 + rolar2 + rolar3;

            Console.WriteLine($"Dados rolados: {rolar1} + {rolar2} + {rolar3} = {total}");

            if ((rolar1 == rolar2) || (rolar2 == rolar3) || (rolar3 == rolar1))
            {
                if ((rolar1 == rolar2) && (rolar2 == rolar3))
                {
                    Console.WriteLine("Você rolou 3 dados iguais!    +6 bônus no total!");
                    total += 6;
                }
                else
                {
                    Console.WriteLine("Você rolou 2 dados iguais!    +2 bônus no total!");
                    total += 2;
                }
            }

            if (total >= 15)
            {
                Console.WriteLine("VOCÊ VENCEU!!!!");
            }
            else
            {
                Console.WriteLine("Desculpe, Você perdeu!!!");
            }
            */

            /*
             Etapa 3 – Usar a instrução if-else para fornecer um prêmio em vez de uma mensagem de vitória ou perda.
            
            Para tornar o jogo mais divertido, em vez de vencer/perder, vamos conceder prêmios fictícios para cada pontuação. Ofereceremos 
            quatro prêmios. O jogador deve ganhar apenas um prêmio.

            - Se a pontuação do jogador for maior ou igual a 16, ele ganhará um carro novo.
            - Se a pontuação do jogador for maior ou igual a 10, ele ganhará um laptop novo.
            - Se a pontuação do jogador for exatamente 7, ele ganhará uma viagem.
            - Caso contrário, ganhará um gatinho.
             */

            Random dado = new Random();

            int rolar1 = dado.Next(1, 7);
            int rolar2 = dado.Next(1, 7);
            int rolar3 = dado.Next(1, 7);

            int total = rolar1 + rolar2 + rolar3;

            Console.WriteLine($"Dados rolados: {rolar1} + {rolar2} + {rolar3} = {total}");

            if ((rolar1 == rolar2) || (rolar2 == rolar3) || (rolar3 == rolar1))
            {
                if ((rolar1 == rolar2) && (rolar2 == rolar3))
                {
                    Console.WriteLine("Você rolou 3 dados iguais!    +6 bônus no total!");
                    total += 6;
                }
                else
                {
                    Console.WriteLine("Você rolou 2 dados iguais!    +2 bônus no total!");
                    total += 2;
                }
            }

            if (total >= 16)
            {
                Console.WriteLine("VOCÊ VENCEU e ganhou um CARRO ZERO KM!!!!");
            }
            else if(total >= 10)
            {
                Console.WriteLine("VOCÊ VENCEU e ganhou um NOTEBOOK!!!!");
            }
            else if (total == 7)
            {
                Console.WriteLine("VOCÊ VENCEU e ganhou uma VIAJEM PARA TAMGAMANDÁPIO!!!!");
            }
            else
            {
                Console.WriteLine("VOCÊ VENCEU e ganhou um GATINHO RESMUNGÃO!");
            }

            Console.ReadLine();
        }
    }
}

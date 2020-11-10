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
             Foi solicitado que você adicionasse um recurso ao software de sua empresa. O recurso destina-se a melhorar a taxa de renovação 
            das assinaturas do software. Sua tarefa é exibir uma mensagem de renovação quando um usuário fizer logon no sistema de software 
            e a assinatura estiver prestes a ser encerrada. Você precisará adicionar um par de instruções de decisão para adicionar 
            corretamente a lógica de ramificação ao aplicativo para atender aos requisitos.
             */

            Random random = new Random();
            int diasExpirar = random.Next(12);
            int descontoPorcentagem = 0;

            if (diasExpirar == 0)
            {
                Console.WriteLine("Sua assinatura expirou");
            }
            else if (diasExpirar == 1)
            {
                Console.WriteLine("Sua assinatura expira em 1 dia!");
                descontoPorcentagem = 20;
            }
            else if (diasExpirar <= 5)
            {
                Console.WriteLine($"Sua assinatura expira em {diasExpirar} dias.");
                descontoPorcentagem = 10;
            }
            else if (diasExpirar <= 10)
            {
                Console.WriteLine("Sua assinatura expira em breve. Renove agora!");
            }

            if (descontoPorcentagem > 0)
            {
                Console.WriteLine($"Renove agora e pague {descontoPorcentagem}%.");
            }

            Console.ReadLine();
        }
    }
}

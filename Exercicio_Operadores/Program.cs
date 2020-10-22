using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Etapa 1 – Escrever código para executar adição, subtração, multiplicação e divisão com ints.
             */

            int soma = 7 + 5;
            int subtracao = 7 - 5;
            int multiplicacao = 7 * 5;
            int divisao = 7 / 5;

            Console.WriteLine("Soma: " + soma);
            Console.WriteLine("Subtração: " + subtracao);
            Console.WriteLine("Multiplicação: " + multiplicacao);
            Console.WriteLine("Divisão: " + divisao);

            /*
             Para ver a divisão funcionando corretamente, precisamos usar um tipo de dados que dê suporte a 
            dígitos fracionários após o ponto decimal, como decimal.
             */

            decimal quocienteDecimal = 7.0m / 5;

            Console.WriteLine("Quociente Decimal: " + quocienteDecimal);

            /*
             Para que isso funcione, o quociente (à esquerda do operador de atribuição) deve ser do tipo 
            decimal e o dividendo ou o divisor deve ser do tipo decimal (ou ambos).
            
            Aqui temos dois exemplos adicionais que funcionam tão bem quanto o anterior:
             */

            decimal quocienteDecimal2 = 7 / 5.0m;
            decimal quocienteDecimal3 = 7.0m / 5.0m;

            Console.WriteLine("Quociente Decimal: " + quocienteDecimal2);
            Console.WriteLine("Quociente Decimal: " + quocienteDecimal3);

            /*
             No entanto, as seguintes linhas de código não funcionam (ou fornecem resultados imprecisos):
             

            int quocienteDecimal4 = 7 / 5.0m;
            int quocienteDecimal5 = 7.0m / 5;
            int quocienteDecimal6 = 7.0m / 5.0m;
            int quocienteDecimal7 = 7 / 5;

            Console.WriteLine("Quociente Decimal: " + quocienteDecimal4); //Não é possível converter implicitamente tipo "decimal" em "int".Existe uma conversão explícita
            Console.WriteLine("Quociente Decimal: " + quocienteDecimal5); //Não é possível converter implicitamente tipo "decimal" em "int".Existe uma conversão explícita
            Console.WriteLine("Quociente Decimal: " + quocienteDecimal6); //Não é possível converter implicitamente tipo "decimal" em "int".Existe uma conversão explícita
            Console.WriteLine("Quociente Decimal: " + quocienteDecimal7); //Não é possível converter implicitamente tipo "decimal" em "int".Existe uma conversão explícita
            */

            /*
             E se você não estiver trabalhando com valores literais? Em outras palavras, e se você precisar 
            dividir duas variáveis do tipo int, mas não quiser que o resultado seja truncado? Nesse caso,
            você precisa executar uma conversão de tipo de dados de int em decimal. A conversão é um tipo de
            conversão de dados que instrui o compilador a tratar temporariamente um valor como se ele fosse 
            um tipo de dados diferente.
            
            Para converter int em decimal, você adiciona o operador de conversão antes do valor. Use o nome do 
            tipo de dados entre parênteses na frente do valor para convertê-lo. Neste caso, adicionaríamos 
            (decimal) antes das variáveis first e second.

            OBS: Vimos três usos ou sobrecargas para o operador de parênteses: invocação de método, ordem de 
            operações e conversão.
             */

            int primeiro = 7;
            int segundo = 5;
            decimal quociente = (decimal)primeiro / (decimal)segundo;

            Console.WriteLine(quociente);

            /*
             O operador de resto % informa o resto da divisão int. O que você realmente aprende com isso é se um
            número é divisível por outro. Isso pode ser útil durante operações de processamento longo ao percorrer 
            em loop centenas ou milhares de registros de dados quando deseja fornecer comentários para o usuário 
            final após cada 100 registros de dados terem sido processados.
             */

            Console.WriteLine("Resto de 200 / 5: " + (200 % 5));
            Console.WriteLine("Resto de 7 / 5: " + (7 % 5));

            /*
            Como aprendemos no exercício anterior, podemos usar os símbolos () como os operadores de ordem das operações.
            No entanto, esta não é a única forma da ordem das operações ser determinada.
            
            Em matemática, PEMDAS é um acrônimo que ajuda os alunos a se lembrar da ordem em que várias operações são 
            executadas. A ordem é:
            
            - Parêntese (o que estiver dentro do parêntese é executado primeiro)
            - Exponentes
            - Multiplicação e Divisão (da esquerda para a direita)
            - Adição e Subtração (da esquerda para a direita)
            - C# segue a mesma ordem que o acrônimo PEMDAS, exceto pelos exponentes. Embora não haja um operador com exponente 
            em C#, você pode usar o método System.Math.Pow(), que está disponível na Biblioteca de Classes .NET. 
             */

            int valor1 = 3 + 4 * 5;
            int valor2 = (3 + 4) * 5;

            Console.WriteLine(valor1);
            Console.WriteLine(valor2);
            Console.ReadLine();
        }
    }
}

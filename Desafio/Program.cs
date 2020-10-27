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
             Etapa 2: Escreva o código no Editor do .NET para calcular os graus Celsius considerando a temperatura atual em Fahrenheit.
            Para converter temperaturas de graus Fahrenheit para Celsius, primeiro subtraia 32 e, em seguida, multiplique por cinco nonos (5/9).
             */

            int fahrenheit = 94;
            float celsius = (fahrenheit - 32f) * (5f / 9f);

            Console.WriteLine($"A temperatura é {celsius:0.00} celsius");
            Console.ReadLine();

        }
    }
}

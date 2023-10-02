using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora {
    public class Operacoes {
        public static void Soma() {
            Console.Write("Digite o primeiro valor: ");
            double aux1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite o segundo valor: ");
            double aux2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double resultado = aux1 + aux2;
            Console.WriteLine($"O resultado da soma de {aux1} + {aux2} é {resultado}");
        }
        public static void Subtracao() {
            Console.Write("Digite o primeiro valor: ");
            double aux1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite o segundo valor: ");
            double aux2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double resultado = aux1 - aux2;
            Console.WriteLine($"O resultado da Subtração de {aux1} - {aux2} é {resultado}");
        }
        public static void Multiplicacao() {
            Console.Write("Digite o primeiro valor: ");
            double aux1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite o segundo valor: ");
            double aux2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double resultado = aux1 * aux2;
            Console.WriteLine($"O resultado da Multiplicação de {aux1} x {aux2} é {resultado.ToString("F2", CultureInfo.InvariantCulture)}");
        }
        public static void Divisao() {
            Console.Write("Digite o primeiro valor: ");
            double aux1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (aux1 != 0) {
                Console.Write("Digite o segundo valor: ");
                double aux2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                double resultado = aux1 / aux2;
                Console.WriteLine($"O resultado da divisão de {aux1} / {aux2} é {resultado.ToString("F2",CultureInfo.InvariantCulture)}");
                Console.WriteLine("--------------------------------------------------------------------");
            }
            else {
                Console.WriteLine("Impossível realizar divisão por 0");
                Console.WriteLine("--------------------------------------------------------------------");
            }

        }
        public static void RaizQuadrada() {
            Console.Write("Digite o número para tirar a raiz quadrada: ");
            double aux1 = double.Parse(Console.ReadLine());
            double resultado = Math.Sqrt(aux1);
            Console.WriteLine($"A raiz quadrade de {aux1} é igual à {resultado.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}

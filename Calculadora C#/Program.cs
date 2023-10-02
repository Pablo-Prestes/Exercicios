using Calculadora;
using System.Globalization;
using System.Linq.Expressions;

namespace Calculadora {
    class Program {
        static void Main(string[] args) {
                 
            while (true) {
                Console.WriteLine(" ");
                Console.WriteLine("Operações que consigo realizar abaixo");
                Console.WriteLine(" ");
                Console.WriteLine("1° Soma");
                Console.WriteLine("2° Substração");
                Console.WriteLine("3° Multiplicação");
                Console.WriteLine("4° Divisão");
                Console.WriteLine("5° Raiz Quadrada");
                Console.WriteLine("6° Encerrar programa !");
                Console.WriteLine(" ");
                Console.WriteLine("--------------------------------------------------------------------");
                Console.Write("Escolha qual operação você deseja fazer: ");
                int valorUsuario = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine(" ");
                Console.Clear();
                if (valorUsuario > 0 && valorUsuario <= 6) {
                 
                    if (valorUsuario == 1) {
                        Console.WriteLine("Operação escolhida Soma");
                        Console.WriteLine(" ");
                        Operacoes.Soma();                       
                        Console.WriteLine("--------------------------------------------------------------------");
                    }
                    else if (valorUsuario == 2) {
                        Console.WriteLine("Operação escolhida Subtração");
                        Console.WriteLine(" ");
                        Operacoes.Subtracao();
                        Console.WriteLine("--------------------------------------------------------------------");
                    }
                    else if (valorUsuario == 3) {
                        Console.WriteLine("Operação escolhida Multiplicação");
                        Console.WriteLine(" ");
                        Operacoes.Multiplicacao();               
                        Console.WriteLine("--------------------------------------------------------------------");
                    }
                    else if (valorUsuario == 4) {
                        Console.WriteLine("Operação escolhida Divisão");
                        Console.WriteLine(" ");
                        Operacoes.Divisao();
                    }

                    else if (valorUsuario == 5) {
                        Console.WriteLine("Operação escolhida Raiz Quadrada");
                        Console.WriteLine(" ");
                        Operacoes.RaizQuadrada();
                        Console.WriteLine("--------------------------------------------------------------------");
                    }
                    else if (valorUsuario == 6) {
                        Console.WriteLine("Finalizando Programa !");
                        Console.WriteLine("--------------------------------------------------------------------");
                        break;
                      
                    }
                }
                else {
                    Console.WriteLine("Valor Inválido, tente novamente !");
                    Console.WriteLine("--------------------------------------------------------------------");
                }

            }
        }

    }

}
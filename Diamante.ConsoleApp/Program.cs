using System;

namespace Diamante.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args) {
            int x, contador = 0, metadeA, metadeB;
            while (true) {
                Console.WriteLine("Digite um valor que será utilizado para calcular o tamanho do diamante");
                if (!int.TryParse(Console.ReadLine(), out x) || x % 2 == 0) {
                    Console.WriteLine("Digite apenas números e com a condição de que sejam ímpares !!");
                    continue;
                }
                break;
            }
            metadeA = x / 2 ;
            metadeB = x / 2 ;
            int parte2 = 0;
            while (true) {
                if (parte2 == 0) {
                    if ( contador < metadeA || contador > metadeB ) {
                        Console.Write(" ");
                    } else {
                        Console.Write("x");
                    }
                    if (metadeA == 0) {
                        parte2++;
                    }
                    if (contador == x) { 
                        contador = 0;
                        metadeA--;
                        metadeB++;
                        Console.WriteLine();
                        continue;
                        }
                }
                else {
                    if (contador < metadeA || contador > metadeB) {
                        Console.Write(" ");
                    } else {
                        Console.Write("x");
                    }
                    if (contador == x) {
                        contador = 0;
                        metadeA++;
                        metadeB--;
                        Console.WriteLine();
                        continue;
                    }
                    if (metadeB < 1)
                        break;
                }
                contador++;
            }
            Console.ReadLine();
        }
    }
}

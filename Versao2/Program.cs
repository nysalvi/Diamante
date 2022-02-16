using System;

namespace Versao2
{
    internal class Program
    {
        static void Main(string[] args) {
            int x, quantidadeX = 1, quantidadeIteraçao = 0;
            bool alternar = false;
            while (true) {
                Console.WriteLine("Digite um valor que será utilizado para calcular o tamanho do diamante");
                if (!int.TryParse(Console.ReadLine(), out x) || x % 2 == 0) {
                    Console.WriteLine("Digite apenas números e com a condição de que sejam ímpares !!");
                    continue;
                }
                break;
            }
            int quantidadeEspaço = x / 2;
            for (int i = 0; i < Math.Sqrt(x); i++) {
                if (i % x == 0) {
                    quantidadeIteraçao++;
                    if (quantidadeX > 0)
                        Console.Write("X");
                    else
                       Console.Write(" ");
                    Console.WriteLine();
                    quantidadeX += 1 + quantidadeIteraçao*2;
                    quantidadeEspaço = x / 2 - quantidadeIteraçao;
                    continue;
                }
                if (quantidadeEspaço > 0 ) {
                    Console.Write(" ");
                    quantidadeEspaço--;
                }  
                else {
                    if (quantidadeX > 0 ) {                    
                        Console.Write("X");
                        quantidadeX--;
                    }
                    else {
                        quantidadeEspaço = x / 2 - quantidadeIteraçao;
                    }
                }
            }
        }
    }
}

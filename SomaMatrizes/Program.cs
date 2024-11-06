//Utilizando Matrizes:
//Problema "soma_matrizes"
//Fazer um programa para ler duas matrizes de números inteiros A e B, contendo de M linhas e N colunas
//cada (M e N máximo = 10). Depois, gerar uma terceira matriz C onde cada elemento desta é a soma
//dos elementos correspondentes das matrizes originais. Imprimir na tela a matriz gerada. 

namespace SomaMatrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m, n;

            Console.Write("Quantas linhas vai ter cada matriz? ");
            m = int.Parse(Console.ReadLine());

            Console.Write("Quantas colunas vai ter cada matriz? ");
            n = int.Parse(Console.ReadLine());

            int[,] matA = new int[m, n];
            int[,] matB = new int[m, n];
            int[,] matC = new int[m, n];

            Console.WriteLine($"Digite os valores da matriz A:");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"Elemento [{i},{j}]: ");
                    matA[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine($"Digite os valores da matriz B:");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"Elemento [{i},{j}]: ");
                    matB[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matC[i, j] = matA[i, j] + matB[i, j];   
                }
            }

            Console.WriteLine();
            Console.WriteLine("MATRIZ SOMA:");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matC[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

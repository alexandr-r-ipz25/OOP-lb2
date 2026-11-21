namespace OOP_lb2
{
    class Program
    {
        static void SwapColumns(int[,] matrix, int m)
        {
            for (int j = 0; j < m - 1; j += 2)
            {
                for (int i = 0; i < m; i++)
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[i, j + 1];
                    matrix[i, j + 1] = temp;
                }
            }
        }

        static void PrintMatrix(int[,] matrix, int m)
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{matrix[i, j],5}");
                }

                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Enter matrix size M: ");
            int m = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = new int[m, m];

            Console.WriteLine("Enter matrix elements:");

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"Element [{i + 1}, {j + 1}]: ");
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("\nOriginal matrix:");
            PrintMatrix(matrix, m);

            SwapColumns(matrix, m);

            Console.WriteLine("\nMatrix after swapping columns:");
            PrintMatrix(matrix, m);

            Console.WriteLine("\nProgram completed successfully.");
            Console.ReadKey();
        }
    }
}

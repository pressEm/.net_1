using System;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива");
            int size = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = fillMatrix(size);
            printMatrix(matrix);
            printArray(getSumRows(matrix));
            Console.ReadLine();
        }

        static int[] getSumRows(int[,] matrix)
        {
            int[] sumRows = new int[matrix.GetLength(0)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (matrix[i,i] % 2 == 0)
                {
                    sumRows[i] = findSumRow(matrix, i);
                }
            }
            return sumRows;
        }

        static int findSumRow(int[,] matrix, int row)
        {
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sum += matrix[row, i];
            }
            return sum;
        }

        static void printArray(int[] mass)
        {
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                    Console.Write(mass[i] + " ");
            }
            Console.WriteLine();
        }

        static void printMatrix(int[,] mass)
        {
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    Console.Write(mass[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static int[,] fillMatrix(int size)
        {
            int[,] array = new int[size, size];
            Random rnd = new Random();
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    array[i, j] = rnd.Next(10);
                }
            }

            return array;
        }
    }
}
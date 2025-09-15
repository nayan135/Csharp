//sum of diagonal elements of a matrix
using System;
class Program
{
    static void Main(string[] args)
    {
        int sumDiagonal = 0;
        Console.WriteLine("Enter the size of matrix");
        int n = Convert.ToInt32(Console.ReadLine());
        int[,] matrix = new int[n, n];
        Console.WriteLine("Enter the elements of matrix");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i == j)
                {
                    sumDiagonal += matrix[i, j];
                }
            }
        }
        Console.WriteLine("The sum of the diagonal elements is " + sumDiagonal);
    }
}
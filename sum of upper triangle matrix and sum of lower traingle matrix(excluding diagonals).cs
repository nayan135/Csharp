//sum of upper triangle matrix and sum of lower traingle matrix(excluding diagonals)
using System;
class Program

{
    static void Main(string[] args)
    {
        int size;
        Console.WriteLine("enter the size of square matrix ");
        size = Convert.ToInt32(Console.ReadLine());
        int[,] matrix = new int[size, size];
        Console.WriteLine("enter the elements of matrix");
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                matrix[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        int upperSum = 0;

        int lowerSum = 0;
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                if (i < j)
                {
                    upperSum += matrix[i, j];
                }
                else if (i > j)
                {
                    lowerSum += matrix[i, j];
                }
            }
        }
        Console.WriteLine("Sum of upper triangle matrix: " + upperSum);
        Console.WriteLine("Sum of lower triangle matrix: " + lowerSum);
    }
}
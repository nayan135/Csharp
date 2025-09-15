// greatest value in a matrix
using System;
class Program
{
    static void Main(string[] args)
    {
        int row, col;
        Console.WriteLine("Enter the size of matrix(row)");
        row = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the size of matrix(column)");
        col = Convert.ToInt32(Console.ReadLine());
        int[,] matrix = new int[row, col];
        Console.WriteLine("Enter the elements of matrix");
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                matrix[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        //greatest value in the matrix
        int greatest = matrix[0, 0];
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                if (matrix[i, j] > greatest)
                {
                    greatest = matrix[i, j];
                }
            }
        }
        Console.WriteLine("The greatest value in the matrix is " + greatest);
    }
}
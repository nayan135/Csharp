//(actual) max and min in array
using System;
class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Enter the length of an array");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];
        Console.WriteLine("Enter the elements of an array");
        for (int i = 0; i < n; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        int max = arr[0];
        int min = arr[0];
        for (int i = 0; i < n; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
            if (arr[i] < min)
            {
                min = arr[i];
            }
        }
        Console.WriteLine("The maximum number in array is " + max);
        Console.WriteLine("The minimum number in array is " + min);
    }
}
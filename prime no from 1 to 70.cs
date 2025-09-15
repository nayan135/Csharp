using System;
class Program
{
    static void Main(string[] args)
    {
        int n = 70;
        Console.WriteLine("Prime number from 1 to 70");
        for (int i = 2; i <= n; i++)
        {
            int count = 0;
            for (int j = 1; j <= i; j++)
            {
                if (i % j == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
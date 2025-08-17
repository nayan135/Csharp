using System;

public class prime{
    void primefun()
    {
        int c = 0;
        Console.WriteLine("Enter a number");
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 2; i < n; i++)
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
                c++;
                Console.WriteLine(i);
            }
        }
        Console.WriteLine("Total prime count: " + c);
    }

    public static void Main(string[] args)
    {
        prime p = new prime();
       p.primefun();
    }
}

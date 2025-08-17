using System;

public class Odd
{
    private void OddFun()
    {
        Console.WriteLine("Enter a number");
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            if (i % 2 != 0)
            {
                Console.WriteLine(i);
            }
        }
    }

    public static void main(string[] args)
    {
        Odd o = new Odd();
        o.OddFun();
    }
}   


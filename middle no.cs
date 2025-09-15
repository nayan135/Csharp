using System;
class Program
{
    static void Main(String[] args)
    {
        int a, b, c;
        Console.WriteLine("Enter first no");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second no");
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter third no");
        c = Convert.ToInt32(Console.ReadLine());

        if ((a <= b && b <= c) || (c <= b && b <= a))

        {
            Console.WriteLine("The middle no is " + b);
        }
        else if ((b <= a && a <= c) || (c <= a && a <= b))
        {
            Console.WriteLine("The middle no is " + a);
        }
        else
        {
            Console.WriteLine("The middle no is " + c);
        }
    }
}
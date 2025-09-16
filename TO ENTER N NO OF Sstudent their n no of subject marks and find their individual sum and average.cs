using System;
//TO ENTER N NO OF Sstudent their n no of subject marks and find their individual sum and average
class Program
{
    static void Main(string[] args)
    {
        int n, m;

        Console.WriteLine("Enter the number of student");
        n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the number of subject");
        m = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i < n; i++)
        {
            Console.WriteLine("For student " + i);
            int sum = 0;
            float avg=0;
            for (int j = 1; j <= m; j++)
            {
                Console.WriteLine("Enter the marks of subject " + j);
                int marks = Convert.ToInt32(Console.ReadLine());
                sum = sum + marks;
                avg = sum / m;
            }
            Console.WriteLine("The sum of student " + i + " is " + sum);
            Console.WriteLine("The average of student " + i + " is " + avg);
        }
    }
}
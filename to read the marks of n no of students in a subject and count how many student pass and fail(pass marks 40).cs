// to read the marks of n no of students in a subject and count how many student pass and fail(pass marks 40)
using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the no of student");
        int n = Convert.ToInt32(Console.ReadLine());
        //pass marks =40
        int passmarks = 40;
        int x = 0;
        int y = 0;
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("Enter the marks of student " + i);
            int marks = Convert.ToInt32(Console.ReadLine());

            if (marks >= passmarks)
            {
                Console.WriteLine("Student " + i + " is pass");
                x++;
            }
            else
            {
                Console.WriteLine("Student " + i + " is fail");
                y++;
            }
        }
        Console.WriteLine("Total pass student " + x);
        Console.WriteLine("Total fail student " + y);
    }
}
//convert time in seconds to hours minute seconds
using System;
class Program
{
    static void Main(string[] args)
    {
        int input;
        int hours, minutes, seconds;
        Console.WriteLine("Enter time in seconds");
        input = Convert.ToInt32(Console.ReadLine());
        hours = input / 3600;
        minutes = (input % 3600) / 60;
        seconds = (input % 3600) % 60;
        Console.WriteLine("Time is " + hours + " hours " + minutes + " minutes " + seconds + " seconds");

    }
}
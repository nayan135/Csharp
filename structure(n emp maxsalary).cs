//shasank 
using System;
struct Employ
{
    public int id;
    public string name;
    public double salary;



    static void Main(){
     Console.WriteLine("Enter the no. of Employee");
    int n= Convert.ToInt32(Console.ReadLine());
    Employ[] employee = new Employ[n];

    for (int i =0; i<n; i++)
        {
            Console.WriteLine($"Enter the id of {i+1} employee");
            employee[i].id= Convert.ToInt32(Console.ReadLine());
             Console.WriteLine($"Enter the name of {i+1} employee");
             employee[i].name= Console.ReadLine();
         Console.WriteLine($"Enter the salary of {i+1} employee");
            employee[i].salary= Convert.ToDouble(Console.ReadLine());
        }

        Console.WriteLine("====== Details of the Employee ======");
        for (int i=0; i<n; i++)
        {
            Console.WriteLine($"ID:{employee[i].id}");
            Console.WriteLine($"Name:{employee[i].name}");
            Console.WriteLine($"Salary:{employee[i].salary}");
            
            
        }

        Console.WriteLine("=== Salary Limit print=====");
    double salary = employee[0].salary;
 
        for(int i=0; i < n; i++)
        {  
              if (employee[i].salary> salary)
            {
                salary= employee[i].salary;
            }
           

            if(employee[i].salary== salary)
            {
                 Console.WriteLine($"ID:{employee[i].id}");
            Console.WriteLine($"Name:{employee[i].name}");
            Console.WriteLine($"Salary:{employee[i].salary}");
            }
        }
    }
}

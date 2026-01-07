using System;
struct Emp
{
    public int id;
    public string name;
    public string address;



    static void Main(){
     Console.WriteLine("Enter the no. of Employee");
    int n= Convert.ToInt32(Console.ReadLine());
    Emp[] employee = new Emp[n];

    for (int i =0; i<n; i++)
        {
            Console.WriteLine($"Enter the id of {i+1} employee");
            employee[i].id= Convert.ToInt32(Console.ReadLine());
             Console.WriteLine($"Enter the name of {i+1} employee");
             employee[i].name= Console.ReadLine();
         Console.WriteLine($"Enter the address of {i+1} employee");
            employee[i].address= Console.ReadLine();
        }

        Console.WriteLine("====== Details of the Employee ======");
        for (int i=0; i<n; i++)
        {
            Console.WriteLine($"ID:{employee[i].id}");
            Console.WriteLine($"Name:{employee[i].name}");
            Console.WriteLine($"Address:{employee[i].address}");
            
            
        }
    }
}

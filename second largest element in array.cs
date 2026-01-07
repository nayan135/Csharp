using System;
class seclarge
{
    static void Main()
    {
        int n=0;
        Console.Write("Enter the no of element in the array: ");
        n= Convert.ToInt32(Console.ReadLine());
        int[] arr= new int[n];

        for(int i=0; i<n; i++)
        {
            Console.WriteLine($"Enter the {i+1} element:");
            arr[i]= Convert.ToInt32(Console.ReadLine());
        }

int largest= arr[0];
int secondlargest= arr[1];
if(secondlargest> largest)
        {
            int temp= largest;
            largest= secondlargest;
            secondlargest= temp;
        }
        //now sec largeeee
        for(int i=0; i<n; i++)
        {
           
                if (arr[i] > largest)
                {
                    secondlargest= largest;
                    largest= arr[i];
                    
                }
                else if(arr[i]>secondlargest && arr[i] != largest)
            {
                secondlargest= arr[i];
            }
            
            
        }
        Console.WriteLine($"Seond largest element of the array is {secondlargest}");
        
    }
}
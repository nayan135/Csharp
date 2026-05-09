using System;

class Nayan
{
    public static void Main(string[] args)
    {
        int n=5;
        int sub=3;
        int[] VP= new int[n];
        int[] SE= new int[n];
        int[] CN= new int[n];
         int[] totalmarks =new int[n];
         int[] percentage = new int[n];
        try
        {
            for(int i =0; i<n; i++)
            {
                Console.WriteLine("Enter Marks of VP: ");
                VP[i]= Convert.ToInt32(Console.ReadLine());
                 Console.WriteLine("Enter Marks of SE: ");
                SE[i]= Convert.ToInt32(Console.ReadLine());
                 Console.WriteLine("Enter Marks of CN: ");
                CN[i]= Convert.ToInt32(Console.ReadLine());
                

                totalmarks[i]= VP[i] +SE[i]+ CN[i];
                percentage[i] = (totalmarks[i]/300)*100;


            }


        }
        catch(e)
        {
            
        }

    }
}
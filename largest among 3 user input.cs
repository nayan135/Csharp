//Find the largest among three user-input numbers using if-else

using System;
class Program{
public static void Main(string[] args){
int n1 , n2, n3;
Console.WriteLine("Enter three numbers");
n1= Convert.ToInt32(Console.ReadLine());
n2= Convert.ToInt32(Console.ReadLine());
n3= Convert.ToInt32(Console.ReadLine());

if(n1>=n2 && n1>=n3){
    Console.WriteLine(n1+" is largest");
}
else if(n2>=n1 && n2>=n3){
    Console.WriteLine(n2+" is largest");
}
else{
    Console.WriteLine(n3+" is largest");
}
}}
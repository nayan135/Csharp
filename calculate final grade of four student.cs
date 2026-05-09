using System;
class Program{
public static void Main(string[] args){
int n=4;

 string[] name= new string[n];
int[] scores= new int[n];
char[] Grade= new char[n];
 for (int i=0; i<n; i++){
  Console.Write("Enter name of student " + (i+1) + ": ");
name[i] = Console.ReadLine();

Console.Write("Enter exam score");
scores[i] = int.Parse(Console.ReadLine());

if(scores[i]>=90) Grade[i] = 'A';
else if(scores[i]>=80) Grade[i] = 'B';
else if(scores[i]>=70) Grade[i] = 'C';
else if(scores[i]>=60) Grade[i] = 'D';
else Grade[i]='F';

Console.WriteLine();
}
Console.WriteLine("----- Grade Sheet-----");
Console.WriteLine("--NAME------------EXAM Score----- Final Grade---");
for(int i=0; i<n; i++){
Console.WriteLine( name[i]+"  "+   scores[i]+"  "+ Grade[i]);

}
}}
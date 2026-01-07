//vowel and consonant (excluding space)
using System;
class vowel
{
    static void Main()
    {
        Console.WriteLine("Enter a string:");
        string n= Console.ReadLine().ToLower();
        char[] vo={'a','e','i','o','u'};
        int vcount=0;
        int ccount=0;
       
        for(int i=0; i<n.Length; i++)
        {
             bool isvowel= false;
            for (int j=0; j<vo.Length; j++)
            {
                
            
            if (n[i] == vo[j])
            {
                isvowel=true;
                
            }
             
            }
                if (isvowel){
                vcount++;
                
            }
               // else { //if counting space as consonant
                else if (Char.IsLetter(n[i])){
                    ccount++;
                }
            }
        

    Console.WriteLine($"vowels: {vcount} && consonant: {ccount}");
    }

}
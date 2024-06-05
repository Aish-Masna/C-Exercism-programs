using System;
using System.Collections.Generic;
using System.Linq;
public static class Luhn
{
    public static bool IsValid(string number)
    {
         number=number.Replace(" ","");
        if(number.Length<1|| number=="0"){
            return false;
        }
        if(!number.All(char.IsDigit)){
            return false;
        }
        int sum=0;
        bool ddigit=false;
        for (int i = number.Length - 1; i >= 0; i--){
             int digit= number[i]-'0';
              if(ddigit){
                  digit*=2;
                  if(digit>9){
                     digit-=9 ;
                  }
              }
            ddigit=!ddigit;
            sum+=digit;
        }
        return sum%10==0;
        
        throw new NotImplementedException("You need to implement this method.");
    }
    public static void Main(string[] args){
        string number = Console.ReadLine();
        bool res =IsValid(number);

        if (res)
            Console.WriteLine("This number is valid!");
        else
            Console.WriteLine("This number is not valid.");
    }
    
}
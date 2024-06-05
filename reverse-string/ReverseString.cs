using System;

public static class ReverseString
{
    public static string Reverse(string input)
    {   string s="";
        for(int i=input.Length-1;i>=0;i--){
            s+=input[i];    
        }
     return s;
        throw new NotImplementedException("You need to implement this method.");
    }
}
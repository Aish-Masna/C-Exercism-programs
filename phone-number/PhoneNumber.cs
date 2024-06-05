using System;

public class PhoneNumber
{
    public static string Clean(string phoneNumber)
    {
        string nphn="";
        foreach(char i in phoneNumber){
            if(char.IsDigit(i)){
               nphn+=i; 
            }
        }
        if (nphn.Length>10 && nphn.StartsWith('1')){
            nphn=nphn.Substring(1);
        }
        string ac=nphn.Substring(0,3);
        string ec=nphn.Substring(3,3);
        if (ac.StartsWith("1")|| ac.StartsWith("0")||ec.StartsWith("1")||ec.StartsWith("0")){
            
            throw new ArgumentException("Invalid phoneNumber");
        }
        
        if (nphn.Length!=10){
            throw new ArgumentException("Invalid phoneNumber");
        }   
        
        return nphn;
        throw new NotImplementedException("You need to implement this method.");
    }

}
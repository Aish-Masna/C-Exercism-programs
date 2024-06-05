using System;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        
       string sl="";
        bool uppernext=false;
        foreach(char i in identifier){
            if (i==' '){
                sl+="_";
            }
            else if (i=='\0'){
                sl+="CTRL" ;
            }
            else if(i>='α' && i<='ω'){
                continue;
            }
            else if(i=='-'){
                uppernext=true;   
            }
            else if(uppernext){
                sl+=char.ToUpper(i);
                uppernext=false;
            }
             else if(char.IsLetter(i)){
                sl+=i; 
            }
    }
        return sl;
}
}
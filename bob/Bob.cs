using System;
using System.Linq;
public static class Bob
{
    public static string Response(string statement)
    {
        statement=statement.Trim();
        if(string.IsNullOrWhiteSpace(statement)){
            return "Fine. Be that way!";
        }
        else if(statement.EndsWith('?')){
            if( statement.ToUpper()==statement && statement.Any(char.IsLetter)){
                return "Calm down, I know what I'm doing!";
            }
                return "Sure.";
            }

        else if(statement.Any(char.IsLetter) && statement.ToUpper()==statement){
            return "Whoa, chill out!";
        }
        else{
            return "Whatever.";
        }
        throw new NotImplementedException("You need to implement this method.");
    }
}
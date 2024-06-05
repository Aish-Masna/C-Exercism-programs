using System;

public static class Raindrops
{
    public static string Convert(int number)
    {
        if(number%3==0 && number %5==0 && number %7==0){
            return "PlingPlangPlong";
        }
        else if(number%3==0){
            if(number%5==0){
                return "PlingPlang";
            }
            else if(number %7==0){
                return "PlingPlong";
            }
            else if (number %5==0 && number %7==0){
                return "PlingPlangPlong";
            }
            return "Pling";
        }
        else if (number%5==0){
            if(number%7==0){
                return "PlangPlong";
            }
            return "Plang";
        }
        else if (number%7==0){
            if(number %3==0){
                return "PlingPlong";
            }
            return "Plong";
        }
        
        else{
            return number.ToString();
        }
        throw new NotImplementedException("You need to implement this method.");
    }
}
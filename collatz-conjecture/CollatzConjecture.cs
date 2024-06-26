using System;

public static class CollatzConjecture
{
    public static int Steps(int number)
    {
        if (number<=0){
            throw new ArgumentOutOfRangeException("invalid value");
        }
        int c=0;
        while(number>1){
            
            if (number%2==0){
                number=number/2;
            }
            else{
                number=(3*number)+1;
            }
            c++;
        }
        return c;
        throw new NotImplementedException("You need to implement this function");
    }
}
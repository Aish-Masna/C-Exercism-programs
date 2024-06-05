using System;

public enum Classification
{
    Perfect,
    Abundant,
    Deficient
}

public static class PerfectNumbers
{
    public static Classification Classify(int number)
    {
         if (number <= 0)
        {
         throw new ArgumentOutOfRangeException("Number must be a positive integer.");
        }
        int temp=number;
        int sum=0;
        for(int i=1;i<=number/2;i++){
            if( number%i==0){
                sum+=i;
            }
        }
        if(sum==number){
            return Classification.Perfect;
        }
        else if(sum> number){
            return Classification.Abundant;
        }
        else {
            return Classification.Deficient;
        }
        throw new NotImplementedException("You need to implement this method.");
    }
}

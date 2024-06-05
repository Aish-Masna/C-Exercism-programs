using System;

public static class DifferenceOfSquares
{
    public static int CalculateSquareOfSum(int max)
    {
        int sum=0;
        for(int i=0;i<=max;i++){
          sum+=i  ;
        }
        return sum*sum;
        throw new NotImplementedException("You need to implement this method.");
    }

    public static int CalculateSumOfSquares(int max)
    {
        int s=0;
        for(int i=0;i<=max;i++){
            s+=i*i;
        }
        return s;
        throw new NotImplementedException("You need to implement this method.");
    }

    public static int CalculateDifferenceOfSquares(int max)
    {
        int s1=CalculateSquareOfSum(max);
        int s2=CalculateSumOfSquares(max);
        return s1-s2;
        throw new NotImplementedException("You need to implement this method.");
    }
}
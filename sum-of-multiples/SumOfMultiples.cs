using System;
using System.Collections.Generic;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        int sum=0;
        for(int i=0;i<max;i++){
            foreach(int multiple in multiples){
                if(multiple !=0 && i%multiple==0 ){
                    sum+=i;
                    break;
                }
            }
        }
        return sum;
        throw new NotImplementedException("You need to implement this method.");
    }
}
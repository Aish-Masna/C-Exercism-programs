using System;
using System.Collections.Generic;
using System.Linq;

public static class NthPrime
{
    public static int Prime(int n)
    {
        if(n<0){
            throw new ArgumentOutOfRangeException("invalid input");
        }
    int[] sieve = new int[1000000];
        int count = 0;
        int num = 2;

        while (count < n)
        {
            if (sieve[num] == 0)
            {
                count++;
                if (count == n)
                {
                    return num;
                }
                for (int i = num * 2; i < sieve.Length; i += num)
                {
                    sieve[i] = 1;
                }
            }
            num++;
        }

        throw new ArgumentOutOfRangeException("Unexpected error occurred.");
    }
}
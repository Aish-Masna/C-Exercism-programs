using System;
public static class Sieve
{
    public static int[] Primes(int limit)
    {
        if (limit < 0)
        {
            throw new ArgumentOutOfRangeException("Limit must be non-negative.");
        }
        bool[] Isprime = new bool[limit + 1];
        Array.Fill(Isprime, true);
        Isprime[0] = Isprime[1] = false;
        for (int i = 2; i <= limit; i++)
        {
            if (Isprime[i])
            {
                for (int j = i * i; j <= limit; j += i)
                {
                    Isprime[j] = false;
                }
            }
        }
        int count = 0;
        for (int i = 2; i <= limit; i++)
        {
            if (Isprime[i])
            {
                count++;
            }
        }

        int[] primes = new int[count];
        int index = 0;
        for (int i = 2; i <= limit; i++)
        {
            if (Isprime[i])
            {
                primes[index++] = i;
            }
        }

        return primes;

        throw new NotImplementedException("You need to implement this method.");
    }
}
using System;

public static class Gigasecond
{
    public static DateTime Add(DateTime moment)
    {
       return moment.AddSeconds(1_000_000_000);
        throw new NotImplementedException("You need to implement this method.");
    }
}
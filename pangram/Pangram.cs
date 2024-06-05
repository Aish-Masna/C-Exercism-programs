using System;
using System.Linq;
public static class Pangram
{
    public static bool IsPangram(string input)
    {
        input=input.ToLower();
        string a="abcdeifghijklmnopqrstuvwxyz";
        string sortedUniqueChars = string.Concat(input.Where(char.IsLetter).Distinct().OrderBy(c => c));
        return a.All(sortedUniqueChars.Contains);
        throw new NotImplementedException("You need to implement this method.");
    }
}

using System;
using System.Collections.Generic;

public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {
        Dictionary <char,int> counts =new Dictionary<char,int>{
            {'A',0},
            {'C',0},
            {'T',0},
            {'G',0}
        };
        foreach(char n in sequence){
            if (!counts.ContainsKey(n)){
                throw new ArgumentException("Invalid");   
            }
            counts[n]++;
        }
        return counts;
        throw new NotImplementedException("You need to implement this method.");
    }
}
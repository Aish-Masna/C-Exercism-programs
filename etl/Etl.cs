using System;
using System.Collections.Generic;

public static class Etl
{
    public static Dictionary<string, int> Transform(Dictionary<int, string[]> old)
    {
        var mapping=new Dictionary<string,int>();
        foreach(var item in old){
            int points=item.Key;
            string[] letters=item.Value; 
            foreach(string c in letters){
                mapping.Add(c.ToLower(),points);
            }
        }
        return mapping;
        throw new NotImplementedException("You need to implement this method.");
    }
}
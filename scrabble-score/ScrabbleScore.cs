using System;
using System.Collections.Generic;
public static class ScrabbleScore
{
    public static int Score(string input)
    {
        int sum=0;
        var letterValue= new Dictionary<char,int>(){
            {'a',1},{'f',4},
            {'e',1},{'h',4},
            {'i',1},{'v',4},
            {'o',1},{'w',4},
            {'u',1},{'y',4},
            {'l',1},{'k',5},
            {'n',1},{'j',8},
            {'r',1},{'x',8},
            {'s',1},{'q',10},
            {'t',1},{'z',10},
            {'d',2},
            {'g',2},
            {'b',3},
            {'c',3},
            {'m',3},
            {'p',3}
            
        };
        foreach(char c in input.ToLower()){
            if(letterValue.ContainsKey(c)){
                sum+=letterValue[c];
            }
        }
        return sum;
        
        throw new NotImplementedException("You need to implement this method.");
    }
}
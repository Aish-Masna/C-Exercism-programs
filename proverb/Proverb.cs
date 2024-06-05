using System;
using System.Linq;
using System.Collections.Generic;
public static class Proverb
{
    public static string[] Recite(string[] subjects)
    {
        List<string> rhyme = new List<string>();
        for(int i=0;i<subjects.Length-1;i++){
            string line=$"For want of a {subjects[i]} the {subjects[i+1]} was lost.";
            rhyme.Add(line);
        }
        if(subjects.Length>0){
            string lline=$"And all for the want of a {subjects[0]}.";
            rhyme.Add(lline);
        }
        return rhyme.ToArray();
        
        throw new NotImplementedException("You need to implement this method.");
    }
}
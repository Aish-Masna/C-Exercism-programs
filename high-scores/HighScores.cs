using System;
using System.Collections.Generic;
using System.Linq;

public class HighScores
{
    private List<int> scores;
    
    public HighScores(List<int> list)
    {
        this.scores=list;   
    }

    public List<int> Scores()
    {
       return new List<int>(scores);
    }
    public int Latest()
    { 
        if(scores.Count>0){
            return scores[scores.Count-1];
        }  
        throw new InvalidOperationException("No scores available.");
    }

    public int PersonalBest()
    {
        if (scores.Count>0){
           return scores.Max(); 
        } 
        throw new InvalidOperationException("No scores available.");
    }

    public List<int> PersonalTopThree()
    {
        if(scores.Count>0){
            return scores.OrderByDescending(x => x).Take(3).ToList();
        }
        throw new InvalidOperationException("No scores available.");
    }
}
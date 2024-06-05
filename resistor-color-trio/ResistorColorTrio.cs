using System;
using System.Collections.Generic;
public static class ResistorColorTrio
{
    public static string Label(string[] colors)
    {
        var colorValues=new Dictionary<string,int>();
        colorValues.Add("black",0);
        colorValues.Add("brown",1);
        colorValues.Add("red",2);
        colorValues.Add("orange",3);
        colorValues.Add("yellow",4);
        colorValues.Add("green",5);
        colorValues.Add("blue",6);
        colorValues.Add("violet",7);
        colorValues.Add("grey",8);
        colorValues.Add("white",9);
        int value=colorValues[colors[0]]*10 + colorValues[colors[1]];
        if (colors.Length < 3)
    {
        throw new ArgumentException("Two or more colors are required");
    }
        int zeros = colorValues[colors[2]];
        int rValue = value * (int)Math.Pow(10, zeros);

       if (rValue >= 1000)
    {
        return (rValue / 1000) + " kiloohms";
    }
    else
    {
        return rValue + " ohms";
    }
        throw new NotImplementedException("You need to implement this method.");
    }
    }


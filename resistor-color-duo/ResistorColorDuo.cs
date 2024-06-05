using System;
using System.Collections.Generic;
public static class ResistorColorDuo
{
    public static int Value(string[] colors)
    {
        var colorValues= new Dictionary<string, int>();
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
        
        if (colors.Length<2){
           throw new ArgumentException("two colors are required"); 
        }
        int value= colorValues[colors[0]]*10 + colorValues[colors[1]];
        return value;
        throw new NotImplementedException("You need to implement this method.");
    }
}

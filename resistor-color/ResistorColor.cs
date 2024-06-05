using System;

public static class ResistorColor
{
    public static int ColorCode(string color)
    {
       color=color.ToLower();
        switch(color){
                case "black":return 0;
                case "brown":return 1;
                case "red":return 2;
                case "orange":return 3;
                case "yellow":return 4;
                case "green":return 5;
                case "blue":return 6;
                case "violet":return 7;
                case "Grey":return 8;
                case "white":return 9;
        }
        throw new NotImplementedException("You need to implement this method.");
    }

    public static string[] Colors()
    {
        return new string[]{"black","brown","red","orange","yellow","green","blue","violet","grey",
"white"};
        throw new NotImplementedException("You need to implement this method.");
    }
}
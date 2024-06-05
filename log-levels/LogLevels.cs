using System;

static class LogLine
{
    public static string Message(string logLine)
    {
       
        int ci=logLine.IndexOf(':');
        if(ci!=-1 && ci>0 && ci<logLine.Length-1){
            string msg=logLine.Substring(ci+2);
            return msg.Trim();
        }
       
        throw new NotImplementedException("Please implement the (static) LogLine.Message() method");
    }

    public static string LogLevel(string logLine)
    {
        int ob=logLine.IndexOf('[');
        int cb=logLine.IndexOf(']');
        string level=logLine.Substring(ob+1,cb-ob-1);
        return level.ToLower();
        throw new NotImplementedException("Please implement the (static) LogLine.LogLevel() method");
    }

    public static string Reformat(string logLine)
    {
        string msg=Message(logLine);
        string level=LogLevel(logLine);
        return $"{msg} ({level})";
        
        throw new NotImplementedException("Please implement the (static) LogLine.Reformat() method");
    }
}

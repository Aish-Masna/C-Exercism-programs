using System;
using System.Collections;
using System.Linq;
using System.Text.RegularExpressions;
public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        string result = Regex.Replace(phrase.Replace("-", " ").Replace("_", " "),   @"[^\w\s]", "");
        string[] words = result.Split(' ');

        string rs = "";
    foreach(string word in words)
    {
        if (!string.IsNullOrEmpty(word)) {
            rs += char.ToUpper(word[0]);
        }
    }
    return rs;
        
        throw new NotImplementedException("Please implement this function");
    }
}
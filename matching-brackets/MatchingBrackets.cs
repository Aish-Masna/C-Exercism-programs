using System;
using System.Collections.Generic;
public static class MatchingBrackets
{
    public static bool IsPaired(string input)
    {
        Stack<char> stack = new Stack<char>();
         foreach (char c in input)
        {
            if (c == '{' || c == '[' || c == '(')
            {
                stack.Push(c);
            }
            else if (c == '}' || c == ']' || c == ')')
            {
                if (stack.Count == 0)
                {
                    return false;
                }
                char top = stack.Pop();
                if (c == ')' && top != '(' || c == '}' && top != '{' || c == ']' && top != '[')
                {
                    return false;
                }
            }
        }
        return stack.Count == 0; 
        
    }
}

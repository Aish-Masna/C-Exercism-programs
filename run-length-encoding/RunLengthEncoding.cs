using System;
using System.Text;
public static class RunLengthEncoding
{
    public static string Encode(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return string.Empty;
        }

        StringBuilder encoded = new StringBuilder();
        char currentChar = input[0];
        int count = 1;

        for (int i = 1; i < input.Length; i++)
        {
            if (input[i] == currentChar)
            {
                count++;
            }
            else
            {
                if (count > 1)
                {
                    encoded.Append(count);
                }
                encoded.Append(currentChar);
                currentChar = input[i];
                count = 1;
            }
        }

        if (count > 1)
        {
            encoded.Append(count);
        }
        encoded.Append(currentChar);

        return encoded.ToString();
    
        throw new NotImplementedException("You need to implement this method.");
    }

    public static string Decode(string input)
    {
        if (string.IsNullOrEmpty(input))
    {
        return string.Empty;
    }

        StringBuilder decoded = new StringBuilder();
    StringBuilder countStr = new StringBuilder();

    for (int i = 0; i < input.Length; i++)
    {
        if (char.IsDigit(input[i]))
        {
            countStr.Append(input[i]);
        }
        else
        {
            int count = countStr.Length > 0 ? int.Parse(countStr.ToString()) : 1;
            char repeatChar = input[i];
            if (char.IsDigit(repeatChar))
            {
                repeatChar = input[i - 1];
            }
            decoded.Append(new string(repeatChar, count));
            countStr.Clear();
        }
    }

    return decoded.ToString();
        throw new NotImplementedException("You need to implement this method.");
    }
}

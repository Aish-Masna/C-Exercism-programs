using System;

public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand)
    {
        if (firstStrand == secondStrand)
        {
            return 0; 
        }
        if (string.IsNullOrEmpty(firstStrand) && string.IsNullOrEmpty(secondStrand))
        {
            throw new ArgumentException("Both strands must be non-empty.");
        }

        if (firstStrand.Length > secondStrand.Length)
        {
            throw new ArgumentException("The first strand cannot be longer than the second strand.");
        }

        if (firstStrand.Length != secondStrand.Length)
        {
            throw new ArgumentException("Both strands must have the same length.");
        }
        int c=0;
            for(int i=0;i<firstStrand.Length;i++){
            if (firstStrand[i]!=secondStrand[i]){
                c++;
            }
        }
        
        return c;
        
        throw new NotImplementedException("You need to implement this method.");
    }
}
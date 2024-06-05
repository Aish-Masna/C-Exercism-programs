using System;

public static class Series
{
    public static string[] Slices(string numbers, int sliceLength)
    {
        if (sliceLength>numbers.Length || sliceLength<=0){
            throw new ArgumentException("slice length is too large or negative");
        }
        
            int numSlices= numbers.Length-sliceLength+1;
          string[] slices= new string[numSlices];
        for(int i=0; i<numSlices;i++){
          slices[i]=numbers.Substring(i,sliceLength);
        }
        return slices;
        throw new NotImplementedException("You need to implement this method.");
    }
}
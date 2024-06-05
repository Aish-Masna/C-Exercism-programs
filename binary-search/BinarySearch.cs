using System;

public static class BinarySearch
{
    public static int Find(int[] input, int value)
    {
        int l=0;
        int h=input.Length-1;
        while(l<=h){
        int mid=(int)(l+h)/2;
        
        if(value==input[mid]){
            return mid;
        }
        else if(value>input[mid]){
            l=mid+1;
        }
        else if(value<input[mid]){
            h=mid-1;
        }
        }
        return -1;
        
        throw new NotImplementedException("You need to implement this method.");
    }
}
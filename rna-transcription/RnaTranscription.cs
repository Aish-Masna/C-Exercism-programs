using System;

public static class RnaTranscription
{
    public static string ToRna(string nucleotide)
    {
        String RNA="";
        foreach (char c in nucleotide){
            if (c=='A'){
                RNA+='U';
            }
            else if (c=='G'){
                RNA+='C';
            }
             else if (c=='C'){
                RNA+='G';
            }
            else{
                RNA+='A';
            }
           
        }
        return RNA;
        throw new NotImplementedException("You need to implement this method.");
    }
}
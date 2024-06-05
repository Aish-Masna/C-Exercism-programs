using System;

public static class ArmstrongNumbers
{
    public static bool IsArmstrongNumber(int number)
    {
        int temp=number;
        int s=0;
        int l=number.ToString().Length;
        while(number!=0){
            int r=number%10;
            s+=(int)Math.Pow(r,l);
            number=number/10;
        }
        return temp==s;
        
        throw new NotImplementedException("You need to implement this method.");
    }
}
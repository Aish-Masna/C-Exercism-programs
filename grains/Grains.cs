using System;

public static class Grains
{
    public static ulong Square(int n)
    {
        if (n==1){
            return 1;
        }
        else if(n<1 ||n>64){
            throw new ArgumentOutOfRangeException("invalid value");
        }
        else{
            ulong res=(ulong)Math.Pow(2,(n-1));
            return res;
        }
        throw new NotImplementedException("You need to implement this method.");
    }

    public static ulong Total()
    {
       ulong t=0;
        for(int i=1;i<=64;i++){
            t+=Square(i);
        }
        return t;
        throw new NotImplementedException("You need to implement this method.");
    }
}

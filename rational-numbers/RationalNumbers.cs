using System;
using System.Diagnostics;

public static class RealNumberExtension
{
    public static int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return Math.Abs(a);
    }
    public static double Expreal(this int realNumber, RationalNumber r)
    {
        return Math.Pow(realNumber, (double)r.Numerator/r.Denominator);
        throw new NotImplementedException("You need to implement this extension method.");
    }
}

public struct RationalNumber
{
    public int Numerator{get;}
    public int Denominator{get;}
    public RationalNumber(int numerator, int denominator)
    {
        if(denominator==0){
            throw new ArgumentException("denominator cant be zero");
        }
        int gcd= RealNumberExtension.GCD(Math.Abs(numerator),Math.Abs(denominator));
        Numerator=numerator/gcd;
        Denominator=denominator/gcd;
        if(Denominator<0){
            Numerator*=-1;
            Denominator*=-1;
        }  
    }

    public static RationalNumber operator +(RationalNumber r1, RationalNumber r2)
    {
        int n=((r1.Numerator*r2.Denominator) + (r2.Numerator*r1.Denominator));
        int d=(r1.Denominator* r2.Denominator);
        return new RationalNumber(n,d);
        throw new NotImplementedException("You need to implement this operator.");
    }

    public static RationalNumber operator -(RationalNumber r1, RationalNumber r2)
    {
        int n1=((r1.Numerator*r2.Denominator) - (r2.Numerator*r1.Denominator));
        int d1=(r1.Denominator* r2.Denominator);
        return new RationalNumber(n1,d1);
        
        throw new NotImplementedException("You need to implement this operator.");
    }

    public static RationalNumber operator *(RationalNumber r1, RationalNumber r2)
    {
        int n2= r1.Numerator* r2.Numerator;
        int d2=r1.Denominator * r2.Denominator;
        return new RationalNumber(n2,d2);
        throw new NotImplementedException("You need to implement this operator.");
    }

    public static RationalNumber operator /(RationalNumber r1, RationalNumber r2)
    {
        if(r2.Numerator==0){
            throw  new DivideByZeroException("Cant divide by zero");
        }
        else{
           int n3= r1.Numerator * r2.Denominator;
           int d3= r2.Numerator * r1.Denominator;
            return new RationalNumber(n3,d3);   
        } 
        throw new NotImplementedException("You need to implement this operator.");
    }

    public RationalNumber Abs()
    {
        return new RationalNumber(Math.Abs(Numerator), Math.Abs(Denominator));
        throw new NotImplementedException("You need to implement this method.");
    }

    public RationalNumber Reduce()
    {
        int gcd = RealNumberExtension.GCD(Math.Abs(Numerator), Math.Abs(Denominator));
        return new RationalNumber(Numerator / gcd, Denominator / gcd);
        throw new NotImplementedException("You need to implement this method.");
    }

    public RationalNumber Exprational(int power)
    {
        if (power < 0)
    {
        if (Numerator == 0)
        {
            throw new DivideByZeroException("Cannot raise zero to a negative exponent");
        }

        return new RationalNumber((int)Math.Pow(Denominator, Math.Abs(power)), (int)Math.Pow(Numerator, Math.Abs(power)));
    }
    else
    {
        return new RationalNumber((int)Math.Pow(Numerator, power), (int)Math.Pow(Denominator, power));
    }
        throw new NotImplementedException("You need to implement this method.");
    }

    public double Expreal(int baseNumber)
    {
        return Math.Pow(baseNumber, (double)Numerator / Denominator);
        throw new NotImplementedException("You need to implement this method.");
    }
}
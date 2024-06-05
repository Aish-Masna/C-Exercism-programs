using System;

public class SpaceAge
{
    private int _seconds;
    public SpaceAge(int seconds)
    {
        _seconds=seconds;
    }

    public double OnEarth()
    {
        return Math.Round(_seconds/31557600,2)
        throw new NotImplementedException("You need to implement this method.");
    }

    public double OnMercury()
    {
        throw new NotImplementedException("You need to implement this method.");
    }

    public double OnVenus()
    {
        throw new NotImplementedException("You need to implement this method.");
    }

    public double OnMars()
    {
        throw new NotImplementedException("You need to implement this method.");
    }

    public double OnJupiter()
    {
        throw new NotImplementedException("You need to implement this method.");
    }

    public double OnSaturn()
    {
        throw new NotImplementedException("You need to implement this method.");
    }

    public double OnUranus()
    {
        throw new NotImplementedException("You need to implement this method.");
    }

    public double OnNeptune()
    {
        throw new NotImplementedException("You need to implement this method.");
    }
}
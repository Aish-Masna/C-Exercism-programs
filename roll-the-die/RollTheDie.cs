using System;
public class Player
{
    public int RollDie()
    {
        Random rnd= new Random();
        return rnd.Next(1,18);
        throw new NotImplementedException("Please implement the Player.RollDie() method");
    }

    public double GenerateSpellStrength()
    {
        Random rndd= new Random();
         return rndd.NextDouble();
        throw new NotImplementedException("Please implement the Player.GenerateSpellStrength() method");
    }
}

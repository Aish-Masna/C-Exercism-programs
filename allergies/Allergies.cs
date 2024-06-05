using System;
using System.Collections.Generic;
public enum Allergen
{
    Eggs=1,
    Peanuts=2,
    Shellfish=4,
    Strawberries=8,
    Tomatoes=16,
    Chocolate=32,
    Pollen=64,
    Cats=128
}

public class Allergies
{
    private readonly List<Allergen>allergies=new List<Allergen>();
    public Allergies(int mask)
    {
        foreach (Allergen allergen in Enum.GetValues(typeof(Allergen)))
        {
            if ((mask & (int)allergen) != 0)
            {
               allergies.Add(allergen);
            }
        }
    }

    public bool IsAllergicTo(Allergen allergen)
    {
        return allergies.Contains(allergen);
        throw new NotImplementedException("You need to implement this method.");
    }

    public Allergen[] List()
    {
        return allergies.ToArray();
        throw new NotImplementedException("You need to implement this method.");
    }
}
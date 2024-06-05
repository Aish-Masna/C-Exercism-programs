using System;

public class Queen
{
    public Queen(int row, int column)
    {
        Row = row;
        Column = column;
    }

    public int Row { get; }
    public int Column { get; }
}

public static class QueenAttack
{
    public static bool CanAttack(Queen white, Queen black)
    {
        return white.Row == black.Row ||
               white.Column == black.Column ||
               Math.Abs(white.Row - black.Row) == Math.Abs(white.Column - black.Column);
       
        throw new NotImplementedException("You need to implement this method.");
    }

    public static Queen Create(int row, int column)
    {
        if (row < 0 || row >= 8 || column < 0 || column >= 8)
    {
        throw new ArgumentOutOfRangeException("values are not within the range");
    }
        return new Queen(row,column);
        
        throw new NotImplementedException("You need to implement this method.");
    }
}
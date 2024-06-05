using System;

public static class ErrorHandling
{
    public static void HandleErrorByThrowingException()
    {
        throw new Exception("handling error by throwing exception");
        
        throw new NotImplementedException("You need to implement this method.");
    }

    public static int? HandleErrorByReturningNullableType(string input)
    {
        if (int.TryParse(input, out int result))
    {
        return result;
    }
    else
    {
        return null;
    }
        
        throw new NotImplementedException("You need to implement this method.");
    }
    public static bool HandleErrorWithOutParam(string input, out int result)
    {
        if (int.TryParse(input, out result))
    {
        return true;
    }
    else
    {
        result=0;
        return false;  
    } 
        throw new NotImplementedException("You need to implement this method.");
    }

    public static void DisposableResourcesAreDisposedWhenExceptionIsThrown(IDisposable disposableObject)
    {
         try
    {
        throw new Exception("dfiyfh");
    }
    finally
    {
        disposableObject.Dispose();
    }
        throw new NotImplementedException("You need to implement this method.");
    }
}

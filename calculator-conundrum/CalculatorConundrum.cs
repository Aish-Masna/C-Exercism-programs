using System;

public static class SimpleCalculator
{
    public static string Calculate(int operand1, int operand2, string operation)
    {
        if(operation==null){
            throw new ArgumentNullException("operation can't be null");
        }
        else if(operation==""){
            throw new ArgumentException("operation cant be empty");
        }
        else if(operation.Length>1){
            throw new ArgumentOutOfRangeException("operation is invalid");
        }
        else if (operation=="+"){
            return $"{operand1} + {operand2} = {operand1+operand2}";
        }
        else if (operation=="*"){
            return $"{operand1} * {operand2} = {operand1*operand2}";
        }
        else if(operation=="/"){
            if(operand2==0){
               return "Division by zero is not allowed.";
            }
             return $"{operand1} / {operand2} = {operand1/operand2}"; 
        }
        throw new NotImplementedException("Please implement the SimpleCalculator.Calculate() method");
    }
}

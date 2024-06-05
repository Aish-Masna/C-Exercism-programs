using System;

static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        float interest;
        if (balance<0){
             interest= 3.213f;
        }
        else if(balance>=0 && balance<1000){
            interest=0.5f;   
        }
        else if(balance>=1000 && balance <5000){
            interest=1.621f;
        }
        else{
            interest=2.475f;
        }
        return interest;
        throw new NotImplementedException("Please implement the (static) SavingsAccount.InterestRate() method");
    }

    public static decimal Interest(decimal balance)
    {
        decimal interest= (decimal)InterestRate(balance);
        return (balance *interest)/100;
        
        throw new NotImplementedException("Please implement the (static) SavingsAccount.Interest() method");
    }

    public static decimal AnnualBalanceUpdate(decimal balance)
    {
        decimal interest= (decimal)InterestRate(balance);
        return balance+(balance *interest)/100;
        throw new NotImplementedException("Please implement the (static) SavingsAccount.AnnualBalanceUpdate() method");
    }

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        int yrs=0;
        
            while (balance< targetBalance){
                balance=AnnualBalanceUpdate(balance);
                yrs++;
            }
        return yrs;
        
        throw new NotImplementedException("Please implement the (static) SavingsAccount.YearsBeforeDesiredBalance() method");
    }
}

using System;

static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        if (speed<=0){
            return 0;
        }
        else if (speed>=1 && speed<=4){
            return 1;
        }
        else if(speed>=5 && speed<=8){
            return 0.9;
        }
        else if(speed==9){
            return 0.8;
        }
        else {
            return 0.77;
        }
        throw new NotImplementedException("Please implement the (static) AssemblyLine.SuccessRate() method");
    }
    
    public static double ProductionRatePerHour(int speed)
    {
        double s=SuccessRate(speed);
        return speed*221*s;
        throw new NotImplementedException("Please implement the (static) AssemblyLine.ProductionRatePerHour() method");
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        double m=ProductionRatePerHour(speed);
        return (int)(m/60);
        throw new NotImplementedException("Please implement the (static) AssemblyLine.WorkingItemsPerMinute() method");
    }
}
